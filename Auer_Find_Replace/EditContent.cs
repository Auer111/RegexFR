using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Auer_Find_Replace
{
    public partial class EditContent : Form
    {
        Auer_Find_Replace AFR;
        List<string> dataFiles;
        List<DataManager.jsonObject> myCurrentData;
        string myCurrentDataFilename;

        public EditContent(Auer_Find_Replace afr){
            AFR = afr;
            InitializeComponent();
            ResetForm();
            Show();
        }
        private void EditContent_FormClosing(object sender, FormClosingEventArgs e){AFR.OnWindowRefocus();}

        private void ResetForm() 
        {
            dataFiles = DataManager.GetJsonDataFiles();
            listBox_filelist.Items.Clear();
            dataFiles.ForEach(i => listBox_filelist.Items.Add(Path.GetFileName(i)));
            SetSelectedAction();
        }
        void SetSelectedAction()
        {
            if (listBox_filelist.Items.Count > 0)
            {
                if (myCurrentData == null) { listBox_filelist.SelectedItem = listBox_filelist.Items[0]; ClearStatusIcons(); }
                else { listBox_filelist.SelectedItem = myCurrentDataFilename; }
            }
        }

        private async void ClearStatusIcons(int delay = 0, string specificClear = " ")
        {
            await Task.Delay(delay);
            switch (specificClear) {
                case "C": CREATE_label_status.Text = ""; return;
                case "E": EDIT_label_status.Text = ""; return;
                case "D": DELETE_label_status.Text = ""; return;
                default: CREATE_label_status.Text = ""; EDIT_label_status.Text = ""; DELETE_label_status.Text = ""; CREATE_label_status.BackColor = SystemColors.Control; EDIT_label_status.BackColor = SystemColors.Control; DELETE_label_status.BackColor = SystemColors.Control; return;
            }
        }

        private void listBox_filelist_SelectedValueChanged(object sender, EventArgs e)
        {
            string nDFN = listBox_filelist.SelectedItem.ToString();
            if (myCurrentDataFilename != nDFN) { ClearStatusIcons(); }
            myCurrentDataFilename = nDFN;
            myCurrentData = DataManager.getJsonData(dataFiles.First(f => Path.GetFileName(f) == myCurrentDataFilename));
            DELETE_label_filename.Text = myCurrentDataFilename;
            EDIT_textbox_filename.Text = myCurrentDataFilename;
            READ_dataGridView.Rows.Clear();
            EDIT_dataGridView.Rows.Clear();
            myCurrentData.ForEach(jso => PopulateDataViews(jso));
        }
        private void PopulateDataViews(DataManager.jsonObject jso)
        {
            READ_dataGridView.Rows.Add(jso.extract, jso.insert);
            EDIT_dataGridView.Rows.Add(jso.extract, jso.insert);
        }

        private void EC_openDIR_button_Click(object sender, EventArgs e){DataManager.OpenDataDir();}

        private void CREATE_button_save_Click(object sender, EventArgs e)
        {
            string fp = CREATE_txtbox_filename.Text.ToString() + ".json";
            CREATE_txtbox_filename.Text = "";
            if (!DataManager.ValidateNewFileName(fp)){CreateFail(); return;}
            if (!DataManager.CreateJsonDataFile(fp)) {CreateFail(); return;}
            myCurrentDataFilename = fp;
            CREATE_label_status.Text = "P";
            CREATE_label_status.BackColor = Color.LightGreen;
            ClearStatusIcons(2000, "C");
            ResetForm();
        }
        private void CreateFail() { CREATE_label_status.Text = "O"; CREATE_label_status.BackColor = Color.PaleVioletRed; }

        private void DELETE_button_file_Click(object sender, EventArgs e)
        {
            if (!DataManager.DeleteJsonDataFile(myCurrentDataFilename)) { DeleteFail(); return; }
            DELETE_label_status.Text = "P";
            DELETE_label_status.BackColor = Color.LightGreen;
            myCurrentDataFilename = null;
            myCurrentData = null;
            ClearStatusIcons(2000,"D");
            ResetForm();
            
        }
        private void DeleteFail() { DELETE_label_status.Text = "O"; DELETE_label_status.BackColor = Color.PaleVioletRed; }

        private void EDIT_button_deleteRow_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in EDIT_dataGridView.SelectedRows)
            {
                EDIT_dataGridView.Rows.Remove(row);
            }
            EDIT_label_status.BackColor = Color.Yellow;
        }

        private void EDIT_button_save_Click(object sender, EventArgs e)
        {
            //Filename Change
            string fnt = EDIT_textbox_filename.Text.ToString();
            if (!DataManager.ValidateRenamedFile(fnt)) { EditFail(); return; }
            if (myCurrentDataFilename != fnt) { DataManager.DeleteJsonDataFile(myCurrentDataFilename); }
            myCurrentDataFilename = fnt;
            //Data Change
            myCurrentData = JsonDataUpdate();
            if (!DataManager.OverwriteJsonDataFile(myCurrentDataFilename, myCurrentData)) {EditFail(); return; }
            EDIT_label_status.Text =  "P";
            EDIT_label_status.BackColor = Color.LightGreen;
            ClearStatusIcons(2000, "E");
            ResetForm();
        }
        private void EditFail() { EDIT_label_status.Text = "O"; EDIT_label_status.BackColor = Color.PaleVioletRed; }

        private List<DataManager.jsonObject> JsonDataUpdate() 
        {
            List<DataManager.jsonObject> nmd = new List<DataManager.jsonObject>();
            foreach (DataGridViewRow row in EDIT_dataGridView.Rows)
            {
                if (row.Cells[0].Value != null && row.Cells[1].Value != null) {
                    nmd.Add(new DataManager.jsonObject { extract = row.Cells[0].Value.ToString(), insert = row.Cells[1].Value.ToString() });
                }
            }
            return nmd;
        }

        private void EDIT_dataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            EDIT_label_status.BackColor = Color.Yellow;
        }
    }
}
