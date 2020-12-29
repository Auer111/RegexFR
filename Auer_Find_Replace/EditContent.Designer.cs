namespace Auer_Find_Replace
{
    partial class EditContent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditContent));
            this.panel1 = new System.Windows.Forms.Panel();
            this.listBox_filelist = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.EC_openDIR_button = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.TabPage();
            this.panel5 = new System.Windows.Forms.Panel();
            this.DELETE_label_status = new System.Windows.Forms.Label();
            this.DELETE_button_file = new System.Windows.Forms.Button();
            this.DELETE_label_filename = new System.Windows.Forms.Label();
            this.DELETE_label_name = new System.Windows.Forms.Label();
            this.Edit = new System.Windows.Forms.TabPage();
            this.panel4 = new System.Windows.Forms.Panel();
            this.EDIT_label_status = new System.Windows.Forms.Label();
            this.EDIT_textbox_filename = new System.Windows.Forms.TextBox();
            this.EDIT_button_deleteRow = new System.Windows.Forms.Button();
            this.EDIT_button_save = new System.Windows.Forms.Button();
            this.EDIT_dataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Create = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.CREATE_label_status = new System.Windows.Forms.Label();
            this.CREATE_label_extension = new System.Windows.Forms.Label();
            this.CREATE_button_save = new System.Windows.Forms.Button();
            this.CREATE_label_name = new System.Windows.Forms.Label();
            this.CREATE_txtbox_filename = new System.Windows.Forms.TextBox();
            this.Read = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.READ_dataGridView = new System.Windows.Forms.DataGridView();
            this.Extract = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Insert = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabsCRUD = new System.Windows.Forms.TabControl();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel1.SuspendLayout();
            this.Delete.SuspendLayout();
            this.panel5.SuspendLayout();
            this.Edit.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EDIT_dataGridView)).BeginInit();
            this.Create.SuspendLayout();
            this.panel3.SuspendLayout();
            this.Read.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.READ_dataGridView)).BeginInit();
            this.tabsCRUD.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.listBox_filelist);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.EC_openDIR_button);
            this.panel1.Location = new System.Drawing.Point(10, 11);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(164, 361);
            this.panel1.TabIndex = 12;
            // 
            // listBox_filelist
            // 
            this.listBox_filelist.BackColor = System.Drawing.Color.LightGray;
            this.listBox_filelist.Font = new System.Drawing.Font("Consolas", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox_filelist.FormattingEnabled = true;
            this.listBox_filelist.ItemHeight = 12;
            this.listBox_filelist.Location = new System.Drawing.Point(10, 22);
            this.listBox_filelist.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBox_filelist.Name = "listBox_filelist";
            this.listBox_filelist.Size = new System.Drawing.Size(147, 268);
            this.listBox_filelist.TabIndex = 9;
            this.listBox_filelist.SelectedValueChanged += new System.EventHandler(this.listBox_filelist_SelectedValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Current Files";
            // 
            // EC_openDIR_button
            // 
            this.EC_openDIR_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EC_openDIR_button.Location = new System.Drawing.Point(10, 331);
            this.EC_openDIR_button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EC_openDIR_button.Name = "EC_openDIR_button";
            this.EC_openDIR_button.Size = new System.Drawing.Size(144, 23);
            this.EC_openDIR_button.TabIndex = 2;
            this.EC_openDIR_button.Text = "Open Data Folder";
            this.EC_openDIR_button.UseVisualStyleBackColor = true;
            this.EC_openDIR_button.Click += new System.EventHandler(this.EC_openDIR_button_Click);
            // 
            // Delete
            // 
            this.Delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Delete.Controls.Add(this.panel5);
            this.Delete.Location = new System.Drawing.Point(4, 21);
            this.Delete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Delete.Name = "Delete";
            this.Delete.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Delete.Size = new System.Drawing.Size(590, 336);
            this.Delete.TabIndex = 3;
            this.Delete.Text = "Delete";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel5.Controls.Add(this.DELETE_label_status);
            this.panel5.Controls.Add(this.DELETE_button_file);
            this.panel5.Controls.Add(this.DELETE_label_filename);
            this.panel5.Controls.Add(this.DELETE_label_name);
            this.panel5.Location = new System.Drawing.Point(4, 6);
            this.panel5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(580, 323);
            this.panel5.TabIndex = 1;
            // 
            // DELETE_label_status
            // 
            this.DELETE_label_status.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DELETE_label_status.Font = new System.Drawing.Font("Wingdings 2", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.DELETE_label_status.Location = new System.Drawing.Point(322, 62);
            this.DELETE_label_status.Name = "DELETE_label_status";
            this.DELETE_label_status.Size = new System.Drawing.Size(32, 31);
            this.DELETE_label_status.TabIndex = 24;
            this.DELETE_label_status.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DELETE_button_file
            // 
            this.DELETE_button_file.Location = new System.Drawing.Point(112, 59);
            this.DELETE_button_file.Name = "DELETE_button_file";
            this.DELETE_button_file.Size = new System.Drawing.Size(204, 36);
            this.DELETE_button_file.TabIndex = 4;
            this.DELETE_button_file.Text = "Delete File";
            this.DELETE_button_file.UseVisualStyleBackColor = true;
            this.DELETE_button_file.Click += new System.EventHandler(this.DELETE_button_file_Click);
            // 
            // DELETE_label_filename
            // 
            this.DELETE_label_filename.AutoSize = true;
            this.DELETE_label_filename.Location = new System.Drawing.Point(112, 14);
            this.DELETE_label_filename.Name = "DELETE_label_filename";
            this.DELETE_label_filename.Size = new System.Drawing.Size(85, 13);
            this.DELETE_label_filename.TabIndex = 3;
            this.DELETE_label_filename.Text = "Filename.json";
            // 
            // DELETE_label_name
            // 
            this.DELETE_label_name.AutoSize = true;
            this.DELETE_label_name.Location = new System.Drawing.Point(18, 14);
            this.DELETE_label_name.Name = "DELETE_label_name";
            this.DELETE_label_name.Size = new System.Drawing.Size(67, 13);
            this.DELETE_label_name.TabIndex = 2;
            this.DELETE_label_name.Text = "File Name:";
            // 
            // Edit
            // 
            this.Edit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Edit.Controls.Add(this.panel4);
            this.Edit.Location = new System.Drawing.Point(4, 21);
            this.Edit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Edit.Name = "Edit";
            this.Edit.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Edit.Size = new System.Drawing.Size(590, 336);
            this.Edit.TabIndex = 2;
            this.Edit.Text = "Edit";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel4.Controls.Add(this.EDIT_label_status);
            this.panel4.Controls.Add(this.EDIT_textbox_filename);
            this.panel4.Controls.Add(this.EDIT_button_deleteRow);
            this.panel4.Controls.Add(this.EDIT_button_save);
            this.panel4.Controls.Add(this.EDIT_dataGridView);
            this.panel4.Location = new System.Drawing.Point(4, 6);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(580, 323);
            this.panel4.TabIndex = 1;
            // 
            // EDIT_label_status
            // 
            this.EDIT_label_status.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.EDIT_label_status.Font = new System.Drawing.Font("Wingdings 2", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.EDIT_label_status.Location = new System.Drawing.Point(553, 3);
            this.EDIT_label_status.Name = "EDIT_label_status";
            this.EDIT_label_status.Size = new System.Drawing.Size(24, 24);
            this.EDIT_label_status.TabIndex = 23;
            this.EDIT_label_status.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EDIT_textbox_filename
            // 
            this.EDIT_textbox_filename.Location = new System.Drawing.Point(61, 4);
            this.EDIT_textbox_filename.Name = "EDIT_textbox_filename";
            this.EDIT_textbox_filename.Size = new System.Drawing.Size(213, 20);
            this.EDIT_textbox_filename.TabIndex = 20;
            // 
            // EDIT_button_deleteRow
            // 
            this.EDIT_button_deleteRow.BackColor = System.Drawing.SystemColors.Control;
            this.EDIT_button_deleteRow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EDIT_button_deleteRow.Font = new System.Drawing.Font("Wingdings 2", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.EDIT_button_deleteRow.Location = new System.Drawing.Point(3, 0);
            this.EDIT_button_deleteRow.Name = "EDIT_button_deleteRow";
            this.EDIT_button_deleteRow.Size = new System.Drawing.Size(52, 29);
            this.EDIT_button_deleteRow.TabIndex = 19;
            this.EDIT_button_deleteRow.Text = "3";
            this.toolTip1.SetToolTip(this.EDIT_button_deleteRow, "Delete Row");
            this.EDIT_button_deleteRow.UseVisualStyleBackColor = false;
            this.EDIT_button_deleteRow.Click += new System.EventHandler(this.EDIT_button_deleteRow_Click);
            // 
            // EDIT_button_save
            // 
            this.EDIT_button_save.BackColor = System.Drawing.SystemColors.Control;
            this.EDIT_button_save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EDIT_button_save.Font = new System.Drawing.Font("Wingdings", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.EDIT_button_save.Location = new System.Drawing.Point(495, 0);
            this.EDIT_button_save.Name = "EDIT_button_save";
            this.EDIT_button_save.Size = new System.Drawing.Size(52, 29);
            this.EDIT_button_save.TabIndex = 18;
            this.EDIT_button_save.Text = "<";
            this.toolTip1.SetToolTip(this.EDIT_button_save, "Save Changes");
            this.EDIT_button_save.UseVisualStyleBackColor = false;
            this.EDIT_button_save.Click += new System.EventHandler(this.EDIT_button_save_Click);
            // 
            // EDIT_dataGridView
            // 
            this.EDIT_dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.EDIT_dataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.EDIT_dataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.EDIT_dataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.EDIT_dataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.EDIT_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EDIT_dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.EDIT_dataGridView.Location = new System.Drawing.Point(3, 31);
            this.EDIT_dataGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EDIT_dataGridView.Name = "EDIT_dataGridView";
            this.EDIT_dataGridView.RowHeadersVisible = false;
            this.EDIT_dataGridView.RowHeadersWidth = 51;
            this.EDIT_dataGridView.RowTemplate.Height = 24;
            this.EDIT_dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.EDIT_dataGridView.ShowCellErrors = false;
            this.EDIT_dataGridView.ShowCellToolTips = false;
            this.EDIT_dataGridView.ShowEditingIcon = false;
            this.EDIT_dataGridView.ShowRowErrors = false;
            this.EDIT_dataGridView.Size = new System.Drawing.Size(575, 290);
            this.EDIT_dataGridView.TabIndex = 1;
            this.EDIT_dataGridView.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.EDIT_dataGridView_CellEndEdit);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Extract";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Insert";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Create
            // 
            this.Create.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Create.Controls.Add(this.panel3);
            this.Create.Location = new System.Drawing.Point(4, 21);
            this.Create.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Create.Name = "Create";
            this.Create.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Create.Size = new System.Drawing.Size(590, 336);
            this.Create.TabIndex = 1;
            this.Create.Text = "Create";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel3.Controls.Add(this.CREATE_label_status);
            this.panel3.Controls.Add(this.CREATE_label_extension);
            this.panel3.Controls.Add(this.CREATE_button_save);
            this.panel3.Controls.Add(this.CREATE_label_name);
            this.panel3.Controls.Add(this.CREATE_txtbox_filename);
            this.panel3.Location = new System.Drawing.Point(4, 6);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(580, 323);
            this.panel3.TabIndex = 1;
            // 
            // CREATE_label_status
            // 
            this.CREATE_label_status.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CREATE_label_status.Font = new System.Drawing.Font("Wingdings 2", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.CREATE_label_status.Location = new System.Drawing.Point(322, 62);
            this.CREATE_label_status.Name = "CREATE_label_status";
            this.CREATE_label_status.Size = new System.Drawing.Size(32, 30);
            this.CREATE_label_status.TabIndex = 22;
            this.CREATE_label_status.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CREATE_label_extension
            // 
            this.CREATE_label_extension.AutoSize = true;
            this.CREATE_label_extension.Location = new System.Drawing.Point(319, 17);
            this.CREATE_label_extension.Name = "CREATE_label_extension";
            this.CREATE_label_extension.Size = new System.Drawing.Size(37, 13);
            this.CREATE_label_extension.TabIndex = 3;
            this.CREATE_label_extension.Text = ".json";
            // 
            // CREATE_button_save
            // 
            this.CREATE_button_save.Location = new System.Drawing.Point(112, 59);
            this.CREATE_button_save.Name = "CREATE_button_save";
            this.CREATE_button_save.Size = new System.Drawing.Size(204, 36);
            this.CREATE_button_save.TabIndex = 2;
            this.CREATE_button_save.Text = "Create File";
            this.CREATE_button_save.UseVisualStyleBackColor = true;
            this.CREATE_button_save.Click += new System.EventHandler(this.CREATE_button_save_Click);
            // 
            // CREATE_label_name
            // 
            this.CREATE_label_name.AutoSize = true;
            this.CREATE_label_name.Location = new System.Drawing.Point(18, 14);
            this.CREATE_label_name.Name = "CREATE_label_name";
            this.CREATE_label_name.Size = new System.Drawing.Size(67, 13);
            this.CREATE_label_name.TabIndex = 1;
            this.CREATE_label_name.Text = "File Name:";
            // 
            // CREATE_txtbox_filename
            // 
            this.CREATE_txtbox_filename.Location = new System.Drawing.Point(112, 11);
            this.CREATE_txtbox_filename.Name = "CREATE_txtbox_filename";
            this.CREATE_txtbox_filename.Size = new System.Drawing.Size(204, 20);
            this.CREATE_txtbox_filename.TabIndex = 0;
            // 
            // Read
            // 
            this.Read.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Read.Controls.Add(this.panel2);
            this.Read.Location = new System.Drawing.Point(4, 21);
            this.Read.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Read.Name = "Read";
            this.Read.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Read.Size = new System.Drawing.Size(590, 336);
            this.Read.TabIndex = 0;
            this.Read.Text = "Read";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panel2.Controls.Add(this.READ_dataGridView);
            this.panel2.Location = new System.Drawing.Point(4, 6);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(580, 323);
            this.panel2.TabIndex = 0;
            // 
            // READ_dataGridView
            // 
            this.READ_dataGridView.AllowUserToAddRows = false;
            this.READ_dataGridView.AllowUserToDeleteRows = false;
            this.READ_dataGridView.AllowUserToResizeRows = false;
            this.READ_dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.READ_dataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.READ_dataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.READ_dataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.READ_dataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.READ_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.READ_dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Extract,
            this.Insert});
            this.READ_dataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.READ_dataGridView.Location = new System.Drawing.Point(3, 2);
            this.READ_dataGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.READ_dataGridView.MultiSelect = false;
            this.READ_dataGridView.Name = "READ_dataGridView";
            this.READ_dataGridView.ReadOnly = true;
            this.READ_dataGridView.RowHeadersVisible = false;
            this.READ_dataGridView.RowHeadersWidth = 51;
            this.READ_dataGridView.RowTemplate.Height = 24;
            this.READ_dataGridView.ShowCellErrors = false;
            this.READ_dataGridView.ShowCellToolTips = false;
            this.READ_dataGridView.ShowEditingIcon = false;
            this.READ_dataGridView.ShowRowErrors = false;
            this.READ_dataGridView.Size = new System.Drawing.Size(575, 317);
            this.READ_dataGridView.TabIndex = 0;
            // 
            // Extract
            // 
            this.Extract.HeaderText = "Extract";
            this.Extract.MinimumWidth = 6;
            this.Extract.Name = "Extract";
            this.Extract.ReadOnly = true;
            this.Extract.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Insert
            // 
            this.Insert.HeaderText = "Insert";
            this.Insert.MinimumWidth = 6;
            this.Insert.Name = "Insert";
            this.Insert.ReadOnly = true;
            this.Insert.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // tabsCRUD
            // 
            this.tabsCRUD.Controls.Add(this.Read);
            this.tabsCRUD.Controls.Add(this.Create);
            this.tabsCRUD.Controls.Add(this.Edit);
            this.tabsCRUD.Controls.Add(this.Delete);
            this.tabsCRUD.Location = new System.Drawing.Point(181, 11);
            this.tabsCRUD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabsCRUD.Name = "tabsCRUD";
            this.tabsCRUD.SelectedIndex = 0;
            this.tabsCRUD.Size = new System.Drawing.Size(598, 361);
            this.tabsCRUD.TabIndex = 13;
            // 
            // EditContent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(5F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 383);
            this.Controls.Add(this.tabsCRUD);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Consolas", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "EditContent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit Content";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EditContent_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.Delete.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.Edit.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EDIT_dataGridView)).EndInit();
            this.Create.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.Read.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.READ_dataGridView)).EndInit();
            this.tabsCRUD.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox listBox_filelist;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button EC_openDIR_button;
        private System.Windows.Forms.TabPage Delete;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TabPage Edit;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TabPage Create;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TabPage Read;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView READ_dataGridView;
        private System.Windows.Forms.TabControl tabsCRUD;
        private System.Windows.Forms.DataGridView EDIT_dataGridView;
        private System.Windows.Forms.Label CREATE_label_extension;
        private System.Windows.Forms.Button CREATE_button_save;
        private System.Windows.Forms.Label CREATE_label_name;
        private System.Windows.Forms.TextBox CREATE_txtbox_filename;
        private System.Windows.Forms.Label DELETE_label_filename;
        private System.Windows.Forms.Label DELETE_label_name;
        private System.Windows.Forms.Button DELETE_button_file;
        private System.Windows.Forms.Button EDIT_button_save;
        private System.Windows.Forms.Button EDIT_button_deleteRow;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Extract;
        private System.Windows.Forms.DataGridViewTextBoxColumn Insert;
        private System.Windows.Forms.TextBox EDIT_textbox_filename;
        private System.Windows.Forms.Label CREATE_label_status;
        private System.Windows.Forms.Label DELETE_label_status;
        private System.Windows.Forms.Label EDIT_label_status;
    }
}