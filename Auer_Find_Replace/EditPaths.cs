using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Auer_Find_Replace
{
    public partial class EditPaths : Form
    {
        Auer_Find_Replace AFR;
        public EditPaths(Auer_Find_Replace afr)
        {
            AFR = afr;
            InitializeComponent();
            ResetForm();
            Show();
        }
        private void ResetForm() {

            List<string> dataFiles = DataManager.DeserializeFilePaths();
            Paths_dataGridView.Rows.Clear();
            dataFiles.ForEach(i => Paths_dataGridView.Rows.Add(i));
            
            List<string> dataExtensions = DataManager.DeserializeExtensions();
            Extensions_dataGridView.Rows.Clear();
            dataExtensions.ForEach(i => Extensions_dataGridView.Rows.Add(i));
            
        }

        private void EditPaths_FormClosing(object sender, FormClosingEventArgs e){AFR.OnWindowRefocus();}

        private void FilePath_button_save_Click(object sender, EventArgs e)
        {

            //DataManager.
            List<string> savedata = ValidateFieldContents(Paths_dataGridView);
            if (!DataManager.SerializeFilePaths(savedata)) { EditPathsFail(); return; }
            Paths_Status_checkbox.Text = "P";
            Paths_Status_checkbox.BackColor = Color.LightGreen;
            ClearStatusIcons(2000, "P");
            ResetForm();
        }
        private void EditPathsFail() { Paths_Status_checkbox.Text = "O"; Paths_Status_checkbox.BackColor = Color.PaleVioletRed; }

        private void EXTENSIONS_button_save_Click(object sender, EventArgs e)
        {
            
            //DataManager.
            List<string> savedata = ValidateFieldContents(Extensions_dataGridView);
            if (!DataManager.SerializeExtensions(savedata)) { EditExtFail(); return; }
            Extensions_Status_checkbox.Text = "P";
            Extensions_Status_checkbox.BackColor = Color.LightGreen;
            ClearStatusIcons(2000, "E");
            ResetForm();
            
        }
        private void EditExtFail() { Extensions_Status_checkbox.Text = "O"; Extensions_Status_checkbox.BackColor = Color.PaleVioletRed; }

        private List<string> ValidateFieldContents(DataGridView dgv)
        {
            List<string> fps = new List<string>();
            foreach (DataGridViewRow row in dgv.Rows)
            {
                if (row.Cells[0].Value != null)
                {
                    fps.Add(row.Cells[0].Value.ToString());
                }
            }
            return fps;
        }
        private async void ClearStatusIcons(int delay = 0, string specificClear = " ")
        {
            await Task.Delay(delay);
            switch (specificClear)
            {
                case "P": Paths_Status_checkbox.Text = ""; return;
                case "E": Extensions_Status_checkbox.Text = ""; return;
                default: Extensions_Status_checkbox.Text = ""; Paths_Status_checkbox.Text = "";  return;
            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e){ClearStatusIcons();}

        private void Extensions_button_exclude_Click(object sender, EventArgs e)
        {
            if (!ExcludeLines(Extensions_dataGridView)) { return; }
            Extensions_Status_checkbox.BackColor = Color.Yellow;
        }
        private void Paths_button_exclude_Click(object sender, EventArgs e)
        {
            if (!ExcludeLines(Paths_dataGridView)) { return; }
            Paths_Status_checkbox.BackColor = Color.Yellow;
        }
        private bool ExcludeLines(DataGridView DGV) { bool changes = false;  foreach (DataGridViewRow row in DGV.SelectedRows){ if (row.Cells.Count > 0) { DGV.Rows.Remove(row); changes = true; } } return changes; }

        private void Paths_dataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            Paths_Status_checkbox.BackColor = Color.Yellow;
        }

        private void Extensions_dataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            Extensions_Status_checkbox.BackColor = Color.Yellow;
        }

        private void Paths_dataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            Paths_Status_checkbox.BackColor = Color.Yellow;
        }
    }
}
