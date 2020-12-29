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
    public partial class Auer_Find_Replace : Form
    {
        public static List<string> allPaths = new List<string>();
        public static List<string> allFiles = new List<string>();
        public static string[] allExtensions;
        public static int changecount = 0;

        public static List<FormattingAction> allFormattingActions = new List<FormattingAction>();

        public Auer_Find_Replace()
        {
            InitializeComponent();
            GetSavedProgramData();
            SuffixOff();
        }
        public void OnWindowRefocus() {
            Enabled = true;
            GetSavedProgramData();
            
        }
        private void MenuItemClick(Object sender, EventArgs e) {
            string[] pieces = sender.ToString().Split(' ');
            FilePath.Text = pieces[pieces.Length - 1];
        }
        
        private void GetSavedProgramData() {
            allFormattingActions.Clear();
            actionFlowPanel.Controls.Clear();
            DataManager.DeserializeActions().ForEach(fa => allFormattingActions.Add(new FormattingAction(fa)));
            allFormattingActions.ForEach(fa => actionFlowPanel.Controls.Add(CreateActionButton(fa)));
            GetSavedFiles();
            GetSavedExtensions();
            GetUserSetup();
        }
        void GetUserSetup()
        {
            DataManager.AFR_Settings userSettings = DataManager.DeserializeAFR();
            FilePath.Text = userSettings.Filepath;
            Filepath_suffix.Text = userSettings.FilepathSuffix;
            recursionDepth_textBox.Text = userSettings.RecursionDepth;
            checkBox_removeExisting.Checked = userSettings.RemoveExisting;
            PathSuffix_checkbox.Checked = userSettings.PathSuffixCheckbox;
            for(int i=0; i < listExtensions.Items.Count; i++) 
            {
                listExtensions.SetSelected(i, userSettings.SelectedExtensions.Contains(listExtensions.Items[i].ToString()));
            }
        }
        void GetSavedFiles() {
            //Context Menu Paths - Get
            List<string> paths = DataManager.DeserializeFilePaths();
            if (paths == null) { return; }
            allPaths = paths;
            ContextMenu cm = new ContextMenu();
            paths.ForEach(p => cm.MenuItems.Add(p, MenuItemClick));
            FilePath.ContextMenu = cm;
        }
        void GetSavedExtensions()
        {
            listExtensions.Items.Clear();
            //List of Extensions - Get
            List<string> exts = DataManager.DeserializeExtensions();
            if (exts == null) { return; }
            exts.ForEach(ext => listExtensions.Items.Add(ext));
        }

        private Button CreateActionButton(FormattingAction fa) {

            Button btn = new Button();
            btn.Text = fa.myActionData.actionName;
            btn.Click += (sender, e) => this.Action_Button_Click(btn,e,fa,btn);
            btn.Tag = "disabled";
            btn.BackColor = Color.LightCoral;
            btn.AutoSize = true;
            btn.Cursor = Cursors.Hand;
            toolTip1.SetToolTip(btn, fa.myActionData.actionDescription);
            return btn;
        }

        void Action_Button_Click(object sender, EventArgs e, FormattingAction fa, Button btn)
        {
            if (!fa.enabled)
            {
                fa.enabled = true;
                btn.BackColor = Color.PaleGreen;
            }
            else
            {
                fa.enabled = false;
                btn.BackColor = Color.LightCoral;
            }
        }


        private void GetFiles_Click(object sender, EventArgs e)
        {
            Enabled = false;

            if (listExtensions.SelectedItems == null || listExtensions.SelectedItems.Count < 1) { MessageBox.Show("Select at least 1 file extension from the extensions list."); return; }
            allExtensions = listExtensions.SelectedItems.Cast<string>().ToArray();

            string path = " ";
            if (PathSuffix_checkbox.Checked) { path = FilePath.Text + Filepath_suffix.Text; }
            else { path = FilePath.Text; }

            progressBar_FileGet.Visible = true;
            if (checkBox_removeExisting.Checked) { allFiles.Clear(); dataUiDisplay.Rows.Clear(); }

            FileSelect._AFR = this;
            try { FileSelect.MaxDepth = int.Parse(recursionDepth_textBox.Text); }
            catch { MessageBox.Show("Not a valid recursion depth"); recursionDepth_textBox.Text = "1"; return; }
            
            FileSelect.WalkDirectoryTree(new DirectoryInfo(path), FileSelect.MaxDepth);

            if (allFiles.Count() <= 0 ) {MessageBox.Show("No files found");}
            else {
                dataUiDisplay.Rows.Clear();
                allFiles.ForEach(f => CreateRow(f));
            }
            progressBar_FileGet.Visible = false;
            progressBar_FileGet.Value = 0;

            Enabled = true;
        }

        public void CreateRow(string filepath) {
            DataGridViewRow row = new DataGridViewRow();
            row.CreateCells(dataUiDisplay); 
            row.Cells[0].Value = Path.GetFileName(filepath);
            row.Cells[0].ToolTipText = filepath;
            dataUiDisplay.Rows.Add(row);
            FileCountManager();
        }

        private void FileCountManager() 
        {
            FileCountUI.Text = "Files: " + allFiles.Count.ToString();

            if (allFiles.Count > 0)
            {
                labelNoFiles.Visible = false;
                panelReplaceControls.Visible = true;
                panelReplaceControls.Enabled = true;
            }
            else
            {
                labelNoFiles.Visible = true;
                panelReplaceControls.Enabled = false;
                panelReplaceControls.Visible = false;
            }

        }

        private void FilePath_TextChanged(object sender, EventArgs e){ ValidatePath(); }
        private void Filepath_suffix_TextChanged(object sender, EventArgs e){ ValidatePath(); }

        void ValidatePath()
        {
            //Generate the path
            string path;
            if (PathSuffix_checkbox.Checked) { path = FilePath.Text + Filepath_suffix.Text; }
            else { path = FilePath.Text; }

            //Make sure its a full path
            bool possiblePath;
            try { possiblePath = Path.IsPathRooted(path); }
            catch { possiblePath = false; }

            //Make sure we can connect to this location
            if (possiblePath){possiblePath = DataManager.PossiblePath(path);}

            GetFiles.Enabled = possiblePath;
            if (possiblePath)
            {
                GetFiles.BackColor = Color.LightGreen;
                GetFiles.Text = "Get Files";
                RunReplace.Enabled = true;
                RunReplace.BackColor = Color.LightGreen;

            }
            else { GetFiles.BackColor = Color.Red; GetFiles.Text = "Invalid Path"; }
        }

        private void runReplace_Click(object sender, EventArgs e)
        {
            int eac = EnabledActionsCount();
            if (eac < 1) { MessageBox.Show("No action selected"); return; }



            Enabled = false;

            RunReplace.BackColor = Color.Black;

            progressBar1.Maximum =  allFiles.Count * eac;

            allFormattingActions.ForEach(fa => fa.RunAction(this)); 

            if (allFiles.Count() == 0)
            {
                RunReplace.BackColor = Color.Red;
                MessageBox.Show("Could not retrieve any files at this location");
                RunReplace.BackColor = Color.LightGreen;
                progressBar1.Value = 0;
                RunReplace.Enabled = true;
                changecount = 0;
            }
            else{
                RunReplace.BackColor = Color.Green;
                if (MessageBox.Show(changecount.ToString() + " logs created from " + allFiles.Count.ToString() + " files. \n Open Log?", "Completed", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes){DataManager.OpenLogDir();}
                else{}
                RunReplace.BackColor = Color.LightGreen;
                progressBar1.Value = 0;
                Enabled = true;
                changecount = 0;
            }
                
        }

        private int EnabledActionsCount()
        {
            return allFormattingActions.Where(fa => fa.enabled).Count();
        }

        private void TextBoxKeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                GetFiles.PerformClick();
                e.Handled = true;
            }
        }


        //----Open a new form-------
        private void SwitchFourms(Form f) {
            SaveSettings();
            this.Enabled = false;
        }
        private void action_class_Click(object sender, EventArgs e){ SwitchFourms(new EditActions(this));}
        private void EditContent_forum_button_Click(object sender, EventArgs e){SwitchFourms(new EditContent(this));}
        private void SavedFilePaths_Click(object sender, EventArgs e) { SwitchFourms(new EditPaths(this)); }
        private void ServerButton_Click(object sender, EventArgs e){ SwitchFourms(new EditServers(this)); }

        //----Edit File Collection--------
        private void button_exclude_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataUiDisplay.SelectedRows ){
                allFiles.Remove(row.Cells[0].ToolTipText.ToString());
                dataUiDisplay.Rows.Remove(row);
                FileCountManager();
            }
        }
        private void Invert_Selection_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataUiDisplay.Rows) {
                if (row.Selected == true) { row.Selected = false; } else {row.Selected = true; }
            }
        }
        private void PathSuffix_CheckedChanged(object sender, EventArgs e)
        {
            if (PathSuffix_checkbox.Checked){ SuffixOn(); }
            else{ SuffixOff(); }
        }
        void SuffixOff()
        {
            FilePath.Size = new Size(536, 20);
            Filepath_suffix.Enabled = false;
            Filepath_suffix.Size = new Size(0, 20);
            label_plus.Visible = false;
        }
        void SuffixOn() 
        {
            FilePath.Size = new Size(392, 20);
            Filepath_suffix.Enabled = true;
            Filepath_suffix.Size = new Size(119, 20);
            label_plus.Visible = true;
        }

        private void Auer_Find_Replace_FormClosing(object sender, FormClosingEventArgs e)
        {
            NetworkConnection.openConnections.ForEach(nc => nc.Dispose());
            NetworkConnection.openConnections.Clear();
            SaveSettings();
        }

        private void SaveSettings()
        {
            DataManager.SerializeAFR(new DataManager.AFR_Settings
            {
                Filepath = FilePath.Text,
                FilepathSuffix = Filepath_suffix.Text,
                RecursionDepth = recursionDepth_textBox.Text,
                SelectedExtensions = listExtensions.SelectedItems.Cast<string>().ToList(),
                RemoveExisting = checkBox_removeExisting.Checked,
                PathSuffixCheckbox = PathSuffix_checkbox.Checked
            });
        }

        private void button_Search_Click(object sender, EventArgs e)
        {
            if(dataUiDisplay.Rows.Count < 2) { return; }
            string promptValue = PromptSearch.ShowDialog("Select all items whose path contains:", "Search");

            foreach (DataGridViewRow row in dataUiDisplay.Rows)
            {
                row.Selected = false;
                if (row.Cells[0].ToolTipText.Contains(promptValue)){ row.Selected = true; }
            }

        }
    }
}
