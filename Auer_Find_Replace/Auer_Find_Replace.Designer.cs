namespace Auer_Find_Replace
{
    partial class Auer_Find_Replace
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Auer_Find_Replace));
            this.label1 = new System.Windows.Forms.Label();
            this.GetFiles = new System.Windows.Forms.Button();
            this.dataUiDisplay = new System.Windows.Forms.DataGridView();
            this.PathColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RunReplace = new System.Windows.Forms.Button();
            this.FilePath = new System.Windows.Forms.TextBox();
            this.FileCountUI = new System.Windows.Forms.Label();
            this.listExtensions = new System.Windows.Forms.ListBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelExtension = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panelReplaceControls = new System.Windows.Forms.Panel();
            this.SavedFilePaths = new System.Windows.Forms.Button();
            this.labelNoFiles = new System.Windows.Forms.Label();
            this.button_CRUD = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.EditContent_forum_button = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.actionFlowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.EditContentButton = new System.Windows.Forms.Button();
            this.button_exclude = new System.Windows.Forms.Button();
            this.Invert_Selection = new System.Windows.Forms.Button();
            this.checkBox_removeExisting = new System.Windows.Forms.CheckBox();
            this.ServerButton = new System.Windows.Forms.Button();
            this.Filepath_suffix = new System.Windows.Forms.TextBox();
            this.label_plus = new System.Windows.Forms.Label();
            this.PathSuffix_checkbox = new System.Windows.Forms.CheckBox();
            this.button_Search = new System.Windows.Forms.Button();
            this.progressBar_FileGet = new System.Windows.Forms.ProgressBar();
            this.recursionDepth_textBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataUiDisplay)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panelReplaceControls.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Consolas", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Rooted Directory Path";
            this.toolTip1.SetToolTip(this.label1, "eg C:\\");
            // 
            // GetFiles
            // 
            this.GetFiles.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.GetFiles.BackColor = System.Drawing.Color.Red;
            this.GetFiles.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GetFiles.Font = new System.Drawing.Font("Consolas", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GetFiles.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.GetFiles.Location = new System.Drawing.Point(548, 11);
            this.GetFiles.Name = "GetFiles";
            this.GetFiles.Size = new System.Drawing.Size(138, 38);
            this.GetFiles.TabIndex = 3;
            this.GetFiles.Text = "Invalid Path";
            this.toolTip1.SetToolTip(this.GetFiles, "2. A valid file path must be entered to enable file retrieve\r\n");
            this.GetFiles.UseVisualStyleBackColor = false;
            this.GetFiles.Click += new System.EventHandler(this.GetFiles_Click);
            // 
            // dataUiDisplay
            // 
            this.dataUiDisplay.AllowUserToAddRows = false;
            this.dataUiDisplay.AllowUserToDeleteRows = false;
            this.dataUiDisplay.AllowUserToResizeColumns = false;
            this.dataUiDisplay.AllowUserToResizeRows = false;
            this.dataUiDisplay.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataUiDisplay.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataUiDisplay.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataUiDisplay.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataUiDisplay.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dataUiDisplay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataUiDisplay.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PathColumn});
            this.dataUiDisplay.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataUiDisplay.Location = new System.Drawing.Point(3, 61);
            this.dataUiDisplay.Name = "dataUiDisplay";
            this.dataUiDisplay.ReadOnly = true;
            this.dataUiDisplay.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dataUiDisplay.RowHeadersVisible = false;
            this.dataUiDisplay.RowHeadersWidth = 51;
            this.dataUiDisplay.RowTemplate.Height = 24;
            this.dataUiDisplay.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataUiDisplay.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataUiDisplay.ShowCellErrors = false;
            this.dataUiDisplay.ShowEditingIcon = false;
            this.dataUiDisplay.ShowRowErrors = false;
            this.dataUiDisplay.Size = new System.Drawing.Size(536, 255);
            this.dataUiDisplay.TabIndex = 4;
            // 
            // PathColumn
            // 
            this.PathColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Consolas", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PathColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.PathColumn.HeaderText = "Files to edit";
            this.PathColumn.MinimumWidth = 6;
            this.PathColumn.Name = "PathColumn";
            this.PathColumn.ReadOnly = true;
            this.PathColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.PathColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // RunReplace
            // 
            this.RunReplace.BackColor = System.Drawing.Color.MediumPurple;
            this.RunReplace.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RunReplace.Location = new System.Drawing.Point(469, 6);
            this.RunReplace.Name = "RunReplace";
            this.RunReplace.Size = new System.Drawing.Size(138, 46);
            this.RunReplace.TabIndex = 5;
            this.RunReplace.Text = "Run Actions";
            this.toolTip1.SetToolTip(this.RunReplace, "Run all selected actions on all files in the \"files to edit\" table\r\n");
            this.RunReplace.UseVisualStyleBackColor = false;
            this.RunReplace.Click += new System.EventHandler(this.runReplace_Click);
            // 
            // FilePath
            // 
            this.FilePath.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.FilePath.Location = new System.Drawing.Point(3, 27);
            this.FilePath.Name = "FilePath";
            this.FilePath.Size = new System.Drawing.Size(392, 20);
            this.FilePath.TabIndex = 6;
            this.toolTip1.SetToolTip(this.FilePath, "1. File path must be valid eg C:\\Users");
            this.FilePath.TextChanged += new System.EventHandler(this.FilePath_TextChanged);
            this.FilePath.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TextBoxKeyUp);
            // 
            // FileCountUI
            // 
            this.FileCountUI.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.FileCountUI.AutoSize = true;
            this.FileCountUI.BackColor = System.Drawing.Color.Transparent;
            this.FileCountUI.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FileCountUI.Location = new System.Drawing.Point(0, 8);
            this.FileCountUI.Name = "FileCountUI";
            this.FileCountUI.Size = new System.Drawing.Size(55, 13);
            this.FileCountUI.TabIndex = 7;
            this.FileCountUI.Text = "Files: 0";
            // 
            // listExtensions
            // 
            this.listExtensions.BackColor = System.Drawing.Color.Silver;
            this.listExtensions.FormattingEnabled = true;
            this.listExtensions.ItemHeight = 12;
            this.listExtensions.Items.AddRange(new object[] {
            "aspx",
            "ascx",
            "master",
            "html",
            "htm",
            "txt"});
            this.listExtensions.Location = new System.Drawing.Point(-2, 25);
            this.listExtensions.Name = "listExtensions";
            this.listExtensions.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listExtensions.Size = new System.Drawing.Size(142, 244);
            this.listExtensions.TabIndex = 8;
            // 
            // progressBar1
            // 
            this.progressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar1.Location = new System.Drawing.Point(3, 26);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(460, 23);
            this.progressBar1.Step = 1;
            this.progressBar1.TabIndex = 10;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(3, 7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(158, 22);
            this.panel1.TabIndex = 11;
            // 
            // labelExtension
            // 
            this.labelExtension.AutoSize = true;
            this.labelExtension.BackColor = System.Drawing.Color.Transparent;
            this.labelExtension.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelExtension.Location = new System.Drawing.Point(3, 6);
            this.labelExtension.Name = "labelExtension";
            this.labelExtension.Size = new System.Drawing.Size(67, 13);
            this.labelExtension.TabIndex = 9;
            this.labelExtension.Text = "extensions";
            this.toolTip1.SetToolTip(this.labelExtension, "Select all file extensions you would like to include in the get file action.\r\n\r\n");
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.Silver;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.labelExtension);
            this.panel2.Controls.Add(this.listExtensions);
            this.panel2.Location = new System.Drawing.Point(548, 61);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(138, 255);
            this.panel2.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Webdings", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label2.Location = new System.Drawing.Point(97, 2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "i";
            this.toolTip1.SetToolTip(this.label2, "Select all file extensions you would like to include in the get file action.\r\nMan" +
        "age items on this list by clicking the paths buton under Edit\r\n(found at the bot" +
        "tom left of this window)\r\n");
            // 
            // panelReplaceControls
            // 
            this.panelReplaceControls.BackColor = System.Drawing.Color.Transparent;
            this.panelReplaceControls.Controls.Add(this.FileCountUI);
            this.panelReplaceControls.Controls.Add(this.RunReplace);
            this.panelReplaceControls.Controls.Add(this.progressBar1);
            this.panelReplaceControls.Enabled = false;
            this.panelReplaceControls.ForeColor = System.Drawing.Color.Black;
            this.panelReplaceControls.Location = new System.Drawing.Point(79, 422);
            this.panelReplaceControls.Name = "panelReplaceControls";
            this.panelReplaceControls.Size = new System.Drawing.Size(611, 54);
            this.panelReplaceControls.TabIndex = 13;
            this.panelReplaceControls.Visible = false;
            // 
            // SavedFilePaths
            // 
            this.SavedFilePaths.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SavedFilePaths.Location = new System.Drawing.Point(8, 425);
            this.SavedFilePaths.Name = "SavedFilePaths";
            this.SavedFilePaths.Size = new System.Drawing.Size(66, 24);
            this.SavedFilePaths.TabIndex = 17;
            this.SavedFilePaths.Text = "Paths";
            this.toolTip1.SetToolTip(this.SavedFilePaths, "Custom actions added will appear to the right of this button");
            this.SavedFilePaths.UseVisualStyleBackColor = true;
            this.SavedFilePaths.Click += new System.EventHandler(this.SavedFilePaths_Click);
            // 
            // labelNoFiles
            // 
            this.labelNoFiles.AutoSize = true;
            this.labelNoFiles.Font = new System.Drawing.Font("Consolas", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNoFiles.Location = new System.Drawing.Point(108, 170);
            this.labelNoFiles.Name = "labelNoFiles";
            this.labelNoFiles.Size = new System.Drawing.Size(287, 36);
            this.labelNoFiles.TabIndex = 14;
            this.labelNoFiles.Text = "No Files To Edit!";
            this.toolTip1.SetToolTip(this.labelNoFiles, "1. Enter a valid path above\r\n2. Click \"Get Files\"\r\n");
            // 
            // button_CRUD
            // 
            this.button_CRUD.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_CRUD.Location = new System.Drawing.Point(5, 30);
            this.button_CRUD.Name = "button_CRUD";
            this.button_CRUD.Size = new System.Drawing.Size(66, 24);
            this.button_CRUD.TabIndex = 0;
            this.button_CRUD.Text = "Actions";
            this.toolTip1.SetToolTip(this.button_CRUD, "Custom actions added will appear to the right of this button");
            this.button_CRUD.UseVisualStyleBackColor = true;
            this.button_CRUD.Click += new System.EventHandler(this.action_class_Click);
            // 
            // panel3
            // 
            this.panel3.AutoSize = true;
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.EditContent_forum_button);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.button_CRUD);
            this.panel3.Controls.Add(this.actionFlowPanel);
            this.panel3.Location = new System.Drawing.Point(3, 335);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(685, 87);
            this.panel3.TabIndex = 15;
            // 
            // EditContent_forum_button
            // 
            this.EditContent_forum_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EditContent_forum_button.Location = new System.Drawing.Point(6, 60);
            this.EditContent_forum_button.Name = "EditContent_forum_button";
            this.EditContent_forum_button.Size = new System.Drawing.Size(66, 24);
            this.EditContent_forum_button.TabIndex = 16;
            this.EditContent_forum_button.Text = "Content";
            this.toolTip1.SetToolTip(this.EditContent_forum_button, "Custom actions added will appear to the right of this button");
            this.EditContent_forum_button.UseVisualStyleBackColor = true;
            this.EditContent_forum_button.Click += new System.EventHandler(this.EditContent_forum_button_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Edit";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Black;
            this.panel5.Location = new System.Drawing.Point(6, 19);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(65, 3);
            this.panel5.TabIndex = 14;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Black;
            this.panel4.Location = new System.Drawing.Point(76, 19);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(606, 3);
            this.panel4.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(74, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(391, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Select all of the actions you would like to perform on the files";
            // 
            // actionFlowPanel
            // 
            this.actionFlowPanel.AutoScroll = true;
            this.actionFlowPanel.AutoSize = true;
            this.actionFlowPanel.BackColor = System.Drawing.Color.Transparent;
            this.actionFlowPanel.Location = new System.Drawing.Point(76, 27);
            this.actionFlowPanel.Name = "actionFlowPanel";
            this.actionFlowPanel.Size = new System.Drawing.Size(605, 54);
            this.actionFlowPanel.TabIndex = 11;
            this.toolTip1.SetToolTip(this.actionFlowPanel, "3. Select at least 1 action to run on the files above");
            // 
            // EditContentButton
            // 
            this.EditContentButton.Location = new System.Drawing.Point(7, 64);
            this.EditContentButton.Name = "EditContentButton";
            this.EditContentButton.Size = new System.Drawing.Size(75, 26);
            this.EditContentButton.TabIndex = 16;
            this.EditContentButton.Text = "Content";
            this.toolTip1.SetToolTip(this.EditContentButton, "Custom actions added will appear to the right of this button");
            this.EditContentButton.UseVisualStyleBackColor = true;
            // 
            // button_exclude
            // 
            this.button_exclude.BackColor = System.Drawing.SystemColors.Control;
            this.button_exclude.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_exclude.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_exclude.Font = new System.Drawing.Font("Wingdings 2", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.button_exclude.Location = new System.Drawing.Point(167, 57);
            this.button_exclude.Name = "button_exclude";
            this.button_exclude.Size = new System.Drawing.Size(51, 29);
            this.button_exclude.TabIndex = 16;
            this.button_exclude.Text = "3";
            this.toolTip1.SetToolTip(this.button_exclude, "Remove Selected");
            this.button_exclude.UseVisualStyleBackColor = false;
            this.button_exclude.Click += new System.EventHandler(this.button_exclude_Click);
            // 
            // Invert_Selection
            // 
            this.Invert_Selection.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Invert_Selection.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Invert_Selection.Font = new System.Drawing.Font("Wingdings", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.Invert_Selection.Location = new System.Drawing.Point(224, 57);
            this.Invert_Selection.Name = "Invert_Selection";
            this.Invert_Selection.Size = new System.Drawing.Size(52, 29);
            this.Invert_Selection.TabIndex = 17;
            this.Invert_Selection.Text = "[";
            this.toolTip1.SetToolTip(this.Invert_Selection, "Invert Selection");
            this.Invert_Selection.UseVisualStyleBackColor = true;
            this.Invert_Selection.Click += new System.EventHandler(this.Invert_Selection_Click);
            // 
            // checkBox_removeExisting
            // 
            this.checkBox_removeExisting.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBox_removeExisting.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.checkBox_removeExisting.Checked = true;
            this.checkBox_removeExisting.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_removeExisting.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.checkBox_removeExisting.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.checkBox_removeExisting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox_removeExisting.Font = new System.Drawing.Font("Wingdings 2", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.checkBox_removeExisting.Location = new System.Drawing.Point(479, 57);
            this.checkBox_removeExisting.Name = "checkBox_removeExisting";
            this.checkBox_removeExisting.Size = new System.Drawing.Size(34, 29);
            this.checkBox_removeExisting.TabIndex = 18;
            this.checkBox_removeExisting.Text = "Z";
            this.checkBox_removeExisting.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip1.SetToolTip(this.checkBox_removeExisting, "Keep Existing files on GET");
            this.checkBox_removeExisting.UseVisualStyleBackColor = false;
            // 
            // ServerButton
            // 
            this.ServerButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ServerButton.Location = new System.Drawing.Point(8, 452);
            this.ServerButton.Name = "ServerButton";
            this.ServerButton.Size = new System.Drawing.Size(66, 24);
            this.ServerButton.TabIndex = 22;
            this.ServerButton.Text = "Servers";
            this.toolTip1.SetToolTip(this.ServerButton, "Custom actions added will appear to the right of this button");
            this.ServerButton.UseVisualStyleBackColor = true;
            this.ServerButton.Click += new System.EventHandler(this.ServerButton_Click);
            // 
            // Filepath_suffix
            // 
            this.Filepath_suffix.Location = new System.Drawing.Point(420, 27);
            this.Filepath_suffix.Name = "Filepath_suffix";
            this.Filepath_suffix.Size = new System.Drawing.Size(119, 20);
            this.Filepath_suffix.TabIndex = 19;
            this.Filepath_suffix.TextChanged += new System.EventHandler(this.Filepath_suffix_TextChanged);
            // 
            // label_plus
            // 
            this.label_plus.AutoSize = true;
            this.label_plus.Location = new System.Drawing.Point(401, 30);
            this.label_plus.Name = "label_plus";
            this.label_plus.Size = new System.Drawing.Size(13, 13);
            this.label_plus.TabIndex = 20;
            this.label_plus.Text = "+";
            // 
            // PathSuffix_checkbox
            // 
            this.PathSuffix_checkbox.AutoSize = true;
            this.PathSuffix_checkbox.Location = new System.Drawing.Point(447, 7);
            this.PathSuffix_checkbox.Name = "PathSuffix_checkbox";
            this.PathSuffix_checkbox.Size = new System.Drawing.Size(92, 17);
            this.PathSuffix_checkbox.TabIndex = 21;
            this.PathSuffix_checkbox.Text = "Path Suffix";
            this.PathSuffix_checkbox.UseVisualStyleBackColor = true;
            this.PathSuffix_checkbox.CheckedChanged += new System.EventHandler(this.PathSuffix_CheckedChanged);
            // 
            // button_Search
            // 
            this.button_Search.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Search.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_Search.Font = new System.Drawing.Font("Webdings", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.button_Search.Location = new System.Drawing.Point(282, 58);
            this.button_Search.Name = "button_Search";
            this.button_Search.Size = new System.Drawing.Size(52, 29);
            this.button_Search.TabIndex = 24;
            this.button_Search.Text = "L";
            this.toolTip1.SetToolTip(this.button_Search, "Invert Selection");
            this.button_Search.UseVisualStyleBackColor = true;
            this.button_Search.Click += new System.EventHandler(this.button_Search_Click);
            // 
            // progressBar_FileGet
            // 
            this.progressBar_FileGet.Location = new System.Drawing.Point(3, 61);
            this.progressBar_FileGet.Name = "progressBar_FileGet";
            this.progressBar_FileGet.Size = new System.Drawing.Size(536, 20);
            this.progressBar_FileGet.Step = 1;
            this.progressBar_FileGet.TabIndex = 25;
            this.progressBar_FileGet.Visible = false;
            // 
            // recursionDepth_textBox
            // 
            this.recursionDepth_textBox.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recursionDepth_textBox.Location = new System.Drawing.Point(439, 56);
            this.recursionDepth_textBox.MaxLength = 1;
            this.recursionDepth_textBox.Name = "recursionDepth_textBox";
            this.recursionDepth_textBox.Size = new System.Drawing.Size(34, 30);
            this.recursionDepth_textBox.TabIndex = 26;
            this.recursionDepth_textBox.Text = "1";
            this.recursionDepth_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTip1.SetToolTip(this.recursionDepth_textBox, "Recursion Depth\r\n0 - only get files at current directory");
            // 
            // Auer_Find_Replace
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(5F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(696, 479);
            this.Controls.Add(this.recursionDepth_textBox);
            this.Controls.Add(this.button_Search);
            this.Controls.Add(this.ServerButton);
            this.Controls.Add(this.PathSuffix_checkbox);
            this.Controls.Add(this.label_plus);
            this.Controls.Add(this.Filepath_suffix);
            this.Controls.Add(this.SavedFilePaths);
            this.Controls.Add(this.checkBox_removeExisting);
            this.Controls.Add(this.Invert_Selection);
            this.Controls.Add(this.button_exclude);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.labelNoFiles);
            this.Controls.Add(this.FilePath);
            this.Controls.Add(this.GetFiles);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelReplaceControls);
            this.Controls.Add(this.progressBar_FileGet);
            this.Controls.Add(this.dataUiDisplay);
            this.Font = new System.Drawing.Font("Consolas", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Auer_Find_Replace";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Auer Find & Replace";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Auer_Find_Replace_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dataUiDisplay)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panelReplaceControls.ResumeLayout(false);
            this.panelReplaceControls.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button GetFiles;
        private System.Windows.Forms.DataGridView dataUiDisplay;
        private System.Windows.Forms.Button RunReplace;
        private System.Windows.Forms.TextBox FilePath;
        private System.Windows.Forms.Label FileCountUI;
        private System.Windows.Forms.ListBox listExtensions;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelExtension;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panelReplaceControls;
        private System.Windows.Forms.Label labelNoFiles;
        private System.Windows.Forms.Label label2;
        protected System.Windows.Forms.Button button_CRUD;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.FlowLayoutPanel actionFlowPanel;
        public System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel5;
        protected System.Windows.Forms.Button EditContent_forum_button;
        protected System.Windows.Forms.Button EditContentButton;
        private System.Windows.Forms.Button button_exclude;
        private System.Windows.Forms.Button Invert_Selection;
        private System.Windows.Forms.CheckBox checkBox_removeExisting;
        private System.Windows.Forms.DataGridViewTextBoxColumn PathColumn;
        protected System.Windows.Forms.Button SavedFilePaths;
        private System.Windows.Forms.TextBox Filepath_suffix;
        private System.Windows.Forms.Label label_plus;
        private System.Windows.Forms.CheckBox PathSuffix_checkbox;
        protected System.Windows.Forms.Button ServerButton;
        private System.Windows.Forms.Button button_Search;
        public System.Windows.Forms.ProgressBar progressBar_FileGet;
        private System.Windows.Forms.TextBox recursionDepth_textBox;
    }
}

