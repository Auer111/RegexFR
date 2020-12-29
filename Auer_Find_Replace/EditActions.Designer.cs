namespace Auer_Find_Replace
{
    partial class EditActions
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// Required method for Designer support - do not modify
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditActions));
            this.label4 = new System.Windows.Forms.Label();
            this.listActions = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Delete = new System.Windows.Forms.TabPage();
            this.panel5 = new System.Windows.Forms.Panel();
            this.DELETE_label_desc = new System.Windows.Forms.Label();
            this.DELETE_button = new System.Windows.Forms.Button();
            this.DELETE_label_name = new System.Windows.Forms.Label();
            this.Edit = new System.Windows.Forms.TabPage();
            this.panel4 = new System.Windows.Forms.Panel();
            this.EDIT_about_type_label = new System.Windows.Forms.Label();
            this.EDIT_button_save = new System.Windows.Forms.Button();
            this.EDIT_textbox_description = new System.Windows.Forms.TextBox();
            this.EDIT_textbox_name = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.EDIT_type_dropdown = new System.Windows.Forms.ComboBox();
            this.panel10 = new System.Windows.Forms.Panel();
            this.EDIT_scope_dropdown = new System.Windows.Forms.ComboBox();
            this.panel11 = new System.Windows.Forms.Panel();
            this.EDIT_file_dropdown = new System.Windows.Forms.ComboBox();
            this.Create = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.CREATE_about_type_label = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.CREATE_dropdown_type = new System.Windows.Forms.ComboBox();
            this.CREATE_button_save = new System.Windows.Forms.Button();
            this.CREATE_textbox_description = new System.Windows.Forms.TextBox();
            this.CREATE_textbox_name = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.CREATE_dropdown_scope = new System.Windows.Forms.ComboBox();
            this.panel8 = new System.Windows.Forms.Panel();
            this.CREATE_dropdown_file = new System.Windows.Forms.ComboBox();
            this.Read = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.READ_labelval_desc = new System.Windows.Forms.Label();
            this.READ_labelval_file = new System.Windows.Forms.Label();
            this.READ_labelval_scope = new System.Windows.Forms.Label();
            this.READ_labelval_type = new System.Windows.Forms.Label();
            this.READ_labelval_name = new System.Windows.Forms.Label();
            this.REGEX_labeldesc = new System.Windows.Forms.Label();
            this.READ_labelfile = new System.Windows.Forms.Label();
            this.READ_labelregex = new System.Windows.Forms.Label();
            this.READ_labelType = new System.Windows.Forms.Label();
            this.READ_labelName = new System.Windows.Forms.Label();
            this.tabsCRUD = new System.Windows.Forms.TabControl();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel1.SuspendLayout();
            this.Delete.SuspendLayout();
            this.panel5.SuspendLayout();
            this.Edit.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel11.SuspendLayout();
            this.Create.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            this.Read.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabsCRUD.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(7, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Current Actions";
            // 
            // listActions
            // 
            this.listActions.BackColor = System.Drawing.Color.LightGray;
            this.listActions.Font = new System.Drawing.Font("Consolas", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listActions.FormattingEnabled = true;
            this.listActions.ItemHeight = 15;
            this.listActions.Location = new System.Drawing.Point(11, 23);
            this.listActions.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listActions.Name = "listActions";
            this.listActions.Size = new System.Drawing.Size(167, 349);
            this.listActions.TabIndex = 9;
            this.listActions.SelectedValueChanged += new System.EventHandler(this.listActions_SelectedValueChanged);
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.listActions);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(11, 12);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(187, 385);
            this.panel1.TabIndex = 10;
            // 
            // Delete
            // 
            this.Delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Delete.Controls.Add(this.panel5);
            this.Delete.Location = new System.Drawing.Point(4, 25);
            this.Delete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Delete.Name = "Delete";
            this.Delete.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Delete.Size = new System.Drawing.Size(675, 356);
            this.Delete.TabIndex = 3;
            this.Delete.Text = "Delete";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel5.Controls.Add(this.DELETE_label_desc);
            this.panel5.Controls.Add(this.DELETE_button);
            this.panel5.Controls.Add(this.DELETE_label_name);
            this.panel5.Location = new System.Drawing.Point(5, 6);
            this.panel5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(663, 345);
            this.panel5.TabIndex = 1;
            // 
            // DELETE_label_desc
            // 
            this.DELETE_label_desc.AutoSize = true;
            this.DELETE_label_desc.Location = new System.Drawing.Point(107, 62);
            this.DELETE_label_desc.MaximumSize = new System.Drawing.Size(516, 87);
            this.DELETE_label_desc.Name = "DELETE_label_desc";
            this.DELETE_label_desc.Size = new System.Drawing.Size(125, 17);
            this.DELETE_label_desc.TabIndex = 8;
            this.DELETE_label_desc.Text = "No action selected";
            // 
            // DELETE_button
            // 
            this.DELETE_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DELETE_button.Location = new System.Drawing.Point(29, 270);
            this.DELETE_button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DELETE_button.Name = "DELETE_button";
            this.DELETE_button.Size = new System.Drawing.Size(605, 42);
            this.DELETE_button.TabIndex = 7;
            this.DELETE_button.Text = "DELETE ACTION";
            this.DELETE_button.UseVisualStyleBackColor = true;
            this.DELETE_button.Click += new System.EventHandler(this.DELETE_button_Click);
            // 
            // DELETE_label_name
            // 
            this.DELETE_label_name.AutoSize = true;
            this.DELETE_label_name.Location = new System.Drawing.Point(107, 21);
            this.DELETE_label_name.Name = "DELETE_label_name";
            this.DELETE_label_name.Size = new System.Drawing.Size(125, 17);
            this.DELETE_label_name.TabIndex = 6;
            this.DELETE_label_name.Text = "No action selected";
            // 
            // Edit
            // 
            this.Edit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Edit.Controls.Add(this.panel4);
            this.Edit.Location = new System.Drawing.Point(4, 25);
            this.Edit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Edit.Name = "Edit";
            this.Edit.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Edit.Size = new System.Drawing.Size(675, 356);
            this.Edit.TabIndex = 2;
            this.Edit.Text = "Edit";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel4.Controls.Add(this.EDIT_about_type_label);
            this.panel4.Controls.Add(this.EDIT_button_save);
            this.panel4.Controls.Add(this.EDIT_textbox_description);
            this.panel4.Controls.Add(this.EDIT_textbox_name);
            this.panel4.Controls.Add(this.label17);
            this.panel4.Controls.Add(this.label18);
            this.panel4.Controls.Add(this.label19);
            this.panel4.Controls.Add(this.label20);
            this.panel4.Controls.Add(this.label21);
            this.panel4.Controls.Add(this.panel9);
            this.panel4.Controls.Add(this.panel10);
            this.panel4.Controls.Add(this.panel11);
            this.panel4.Location = new System.Drawing.Point(5, 6);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(663, 345);
            this.panel4.TabIndex = 1;
            // 
            // EDIT_about_type_label
            // 
            this.EDIT_about_type_label.AutoSize = true;
            this.EDIT_about_type_label.Cursor = System.Windows.Forms.Cursors.Help;
            this.EDIT_about_type_label.Font = new System.Drawing.Font("Webdings", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.EDIT_about_type_label.Location = new System.Drawing.Point(367, 66);
            this.EDIT_about_type_label.Name = "EDIT_about_type_label";
            this.EDIT_about_type_label.Size = new System.Drawing.Size(30, 24);
            this.EDIT_about_type_label.TabIndex = 19;
            this.EDIT_about_type_label.Text = "i";
            this.toolTip1.SetToolTip(this.EDIT_about_type_label, "Select an action type from the dropdown\r\nthen hover here for information on that " +
        "action");
            // 
            // EDIT_button_save
            // 
            this.EDIT_button_save.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.EDIT_button_save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EDIT_button_save.Location = new System.Drawing.Point(420, 158);
            this.EDIT_button_save.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EDIT_button_save.Name = "EDIT_button_save";
            this.EDIT_button_save.Size = new System.Drawing.Size(163, 41);
            this.EDIT_button_save.TabIndex = 10;
            this.EDIT_button_save.Text = "SAVE";
            this.EDIT_button_save.UseVisualStyleBackColor = false;
            this.EDIT_button_save.Click += new System.EventHandler(this.EDIT_button_save_Click);
            // 
            // EDIT_textbox_description
            // 
            this.EDIT_textbox_description.AcceptsReturn = true;
            this.EDIT_textbox_description.AcceptsTab = true;
            this.EDIT_textbox_description.Location = new System.Drawing.Point(107, 224);
            this.EDIT_textbox_description.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EDIT_textbox_description.MaxLength = 200;
            this.EDIT_textbox_description.Multiline = true;
            this.EDIT_textbox_description.Name = "EDIT_textbox_description";
            this.EDIT_textbox_description.Size = new System.Drawing.Size(516, 86);
            this.EDIT_textbox_description.TabIndex = 6;
            this.toolTip1.SetToolTip(this.EDIT_textbox_description, "Min Length: 3");
            this.EDIT_textbox_description.TextChanged += new System.EventHandler(this.EDIT_textbox_description_TextChanged);
            // 
            // EDIT_textbox_name
            // 
            this.EDIT_textbox_name.BackColor = System.Drawing.SystemColors.Window;
            this.EDIT_textbox_name.Location = new System.Drawing.Point(107, 18);
            this.EDIT_textbox_name.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EDIT_textbox_name.MaxLength = 20;
            this.EDIT_textbox_name.Name = "EDIT_textbox_name";
            this.EDIT_textbox_name.Size = new System.Drawing.Size(255, 22);
            this.EDIT_textbox_name.TabIndex = 5;
            this.toolTip1.SetToolTip(this.EDIT_textbox_name, "Min Length: 3");
            this.EDIT_textbox_name.TextChanged += new System.EventHandler(this.EDIT_textbox_name_TextChanged);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Cursor = System.Windows.Forms.Cursors.Help;
            this.label17.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(16, 224);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(63, 20);
            this.label17.TabIndex = 4;
            this.label17.Text = "About:";
            this.toolTip1.SetToolTip(this.label17, "a description of your action");
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Cursor = System.Windows.Forms.Cursors.Help;
            this.label18.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(25, 175);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(54, 20);
            this.label18.TabIndex = 3;
            this.label18.Text = "File:";
            this.toolTip1.SetToolTip(this.label18, "To create a new file close this window and select \'Content\' under \'Edit\'\r\nCreate " +
        "your own .json file to have it added it to this list\r\n");
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Cursor = System.Windows.Forms.Cursors.Help;
            this.label19.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(16, 119);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(63, 20);
            this.label19.TabIndex = 2;
            this.label19.Text = "Scope:";
            this.toolTip1.SetToolTip(this.label19, "Where the action will be taking place");
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Cursor = System.Windows.Forms.Cursors.Help;
            this.label20.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(25, 66);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(54, 20);
            this.label20.TabIndex = 1;
            this.label20.Text = "Type:";
            this.toolTip1.SetToolTip(this.label20, "built-in function");
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Cursor = System.Windows.Forms.Cursors.Help;
            this.label21.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(25, 18);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(54, 20);
            this.label21.TabIndex = 0;
            this.label21.Text = "Name:";
            this.toolTip1.SetToolTip(this.label21, "A simple name to describe your action");
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.EDIT_type_dropdown);
            this.panel9.Location = new System.Drawing.Point(103, 63);
            this.panel9.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(264, 33);
            this.panel9.TabIndex = 17;
            // 
            // EDIT_type_dropdown
            // 
            this.EDIT_type_dropdown.BackColor = System.Drawing.SystemColors.Window;
            this.EDIT_type_dropdown.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EDIT_type_dropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.EDIT_type_dropdown.FormattingEnabled = true;
            this.EDIT_type_dropdown.Location = new System.Drawing.Point(4, 4);
            this.EDIT_type_dropdown.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EDIT_type_dropdown.Name = "EDIT_type_dropdown";
            this.EDIT_type_dropdown.Size = new System.Drawing.Size(255, 24);
            this.EDIT_type_dropdown.TabIndex = 7;
            this.EDIT_type_dropdown.SelectedValueChanged += new System.EventHandler(this.EDIT_type_dropdown_SelectedValueChanged);
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.EDIT_scope_dropdown);
            this.panel10.Location = new System.Drawing.Point(103, 114);
            this.panel10.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(264, 33);
            this.panel10.TabIndex = 18;
            // 
            // EDIT_scope_dropdown
            // 
            this.EDIT_scope_dropdown.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EDIT_scope_dropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.EDIT_scope_dropdown.FormattingEnabled = true;
            this.EDIT_scope_dropdown.Location = new System.Drawing.Point(4, 4);
            this.EDIT_scope_dropdown.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EDIT_scope_dropdown.Name = "EDIT_scope_dropdown";
            this.EDIT_scope_dropdown.Size = new System.Drawing.Size(255, 24);
            this.EDIT_scope_dropdown.TabIndex = 8;
            this.EDIT_scope_dropdown.SelectedValueChanged += new System.EventHandler(this.EDIT_scope_dropdown_SelectedValueChanged);
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.EDIT_file_dropdown);
            this.panel11.Location = new System.Drawing.Point(103, 171);
            this.panel11.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(264, 33);
            this.panel11.TabIndex = 18;
            // 
            // EDIT_file_dropdown
            // 
            this.EDIT_file_dropdown.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EDIT_file_dropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.EDIT_file_dropdown.FormattingEnabled = true;
            this.EDIT_file_dropdown.Items.AddRange(new object[] {
            "classchanges"});
            this.EDIT_file_dropdown.Location = new System.Drawing.Point(4, 4);
            this.EDIT_file_dropdown.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EDIT_file_dropdown.Name = "EDIT_file_dropdown";
            this.EDIT_file_dropdown.Size = new System.Drawing.Size(255, 24);
            this.EDIT_file_dropdown.TabIndex = 9;
            this.EDIT_file_dropdown.SelectedValueChanged += new System.EventHandler(this.EDIT_file_dropdown_SelectedValueChanged);
            // 
            // Create
            // 
            this.Create.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Create.Controls.Add(this.panel3);
            this.Create.Location = new System.Drawing.Point(4, 25);
            this.Create.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Create.Name = "Create";
            this.Create.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Create.Size = new System.Drawing.Size(675, 356);
            this.Create.TabIndex = 1;
            this.Create.Text = "Create";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel3.Controls.Add(this.CREATE_about_type_label);
            this.panel3.Controls.Add(this.panel6);
            this.panel3.Controls.Add(this.CREATE_button_save);
            this.panel3.Controls.Add(this.CREATE_textbox_description);
            this.panel3.Controls.Add(this.CREATE_textbox_name);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.panel7);
            this.panel3.Controls.Add(this.panel8);
            this.panel3.Location = new System.Drawing.Point(5, 6);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(663, 345);
            this.panel3.TabIndex = 1;
            // 
            // CREATE_about_type_label
            // 
            this.CREATE_about_type_label.AutoSize = true;
            this.CREATE_about_type_label.Cursor = System.Windows.Forms.Cursors.Help;
            this.CREATE_about_type_label.Font = new System.Drawing.Font("Webdings", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.CREATE_about_type_label.ForeColor = System.Drawing.Color.Black;
            this.CREATE_about_type_label.Location = new System.Drawing.Point(367, 66);
            this.CREATE_about_type_label.Name = "CREATE_about_type_label";
            this.CREATE_about_type_label.Size = new System.Drawing.Size(30, 24);
            this.CREATE_about_type_label.TabIndex = 18;
            this.CREATE_about_type_label.Text = "i";
            this.toolTip1.SetToolTip(this.CREATE_about_type_label, "Select an action type from the dropdown\r\nthen hover here for information on that " +
        "action");
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.CREATE_dropdown_type);
            this.panel6.Location = new System.Drawing.Point(103, 63);
            this.panel6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(264, 33);
            this.panel6.TabIndex = 0;
            // 
            // CREATE_dropdown_type
            // 
            this.CREATE_dropdown_type.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CREATE_dropdown_type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CREATE_dropdown_type.FormattingEnabled = true;
            this.CREATE_dropdown_type.Location = new System.Drawing.Point(4, 4);
            this.CREATE_dropdown_type.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CREATE_dropdown_type.Name = "CREATE_dropdown_type";
            this.CREATE_dropdown_type.Size = new System.Drawing.Size(255, 24);
            this.CREATE_dropdown_type.TabIndex = 12;
            this.CREATE_dropdown_type.SelectedValueChanged += new System.EventHandler(this.CREATE_dropdown_type_SelectedValueChanged);
            // 
            // CREATE_button_save
            // 
            this.CREATE_button_save.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.CREATE_button_save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CREATE_button_save.Location = new System.Drawing.Point(420, 158);
            this.CREATE_button_save.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CREATE_button_save.Name = "CREATE_button_save";
            this.CREATE_button_save.Size = new System.Drawing.Size(163, 41);
            this.CREATE_button_save.TabIndex = 15;
            this.CREATE_button_save.Text = "SAVE";
            this.toolTip1.SetToolTip(this.CREATE_button_save, "All fields must be properly filled out before\r\nthe save button and be used.\r\n\r\nSa" +
        "ved actions will persist accross sessions.\r\n");
            this.CREATE_button_save.UseVisualStyleBackColor = false;
            this.CREATE_button_save.Click += new System.EventHandler(this.CREATE_button_save_Click);
            // 
            // CREATE_textbox_description
            // 
            this.CREATE_textbox_description.AcceptsReturn = true;
            this.CREATE_textbox_description.AcceptsTab = true;
            this.CREATE_textbox_description.Location = new System.Drawing.Point(107, 224);
            this.CREATE_textbox_description.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CREATE_textbox_description.MaxLength = 200;
            this.CREATE_textbox_description.Multiline = true;
            this.CREATE_textbox_description.Name = "CREATE_textbox_description";
            this.CREATE_textbox_description.Size = new System.Drawing.Size(516, 86);
            this.CREATE_textbox_description.TabIndex = 11;
            this.toolTip1.SetToolTip(this.CREATE_textbox_description, "Min Length: 3");
            this.CREATE_textbox_description.TextChanged += new System.EventHandler(this.CREATE_textbox_description_TextChanged);
            // 
            // CREATE_textbox_name
            // 
            this.CREATE_textbox_name.Location = new System.Drawing.Point(107, 18);
            this.CREATE_textbox_name.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CREATE_textbox_name.MaxLength = 20;
            this.CREATE_textbox_name.Name = "CREATE_textbox_name";
            this.CREATE_textbox_name.Size = new System.Drawing.Size(255, 22);
            this.CREATE_textbox_name.TabIndex = 10;
            this.toolTip1.SetToolTip(this.CREATE_textbox_name, "Min Length: 3");
            this.CREATE_textbox_name.TextChanged += new System.EventHandler(this.CREATE_textbox_name_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Cursor = System.Windows.Forms.Cursors.Help;
            this.label7.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(16, 224);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 20);
            this.label7.TabIndex = 4;
            this.label7.Text = "About:";
            this.toolTip1.SetToolTip(this.label7, "Add a description of your action");
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Cursor = System.Windows.Forms.Cursors.Help;
            this.label8.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(25, 175);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 20);
            this.label8.TabIndex = 3;
            this.label8.Text = "File:";
            this.toolTip1.SetToolTip(this.label8, "To create a new file close this window and select \'Content\' under \'Edit\'\r\nCreate " +
        "your own .json file to have it added it to this list\r\n");
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Cursor = System.Windows.Forms.Cursors.Help;
            this.label9.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(16, 119);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 20);
            this.label9.TabIndex = 2;
            this.label9.Text = "Scope:";
            this.toolTip1.SetToolTip(this.label9, "Where the action will be taking place");
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Cursor = System.Windows.Forms.Cursors.Help;
            this.label10.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(25, 66);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 20);
            this.label10.TabIndex = 1;
            this.label10.Text = "Type:";
            this.toolTip1.SetToolTip(this.label10, "Select from built-in functions");
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Cursor = System.Windows.Forms.Cursors.Help;
            this.label11.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(25, 18);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(54, 20);
            this.label11.TabIndex = 0;
            this.label11.Text = "Name:";
            this.toolTip1.SetToolTip(this.label11, "A simple name to describe your action");
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.CREATE_dropdown_scope);
            this.panel7.Location = new System.Drawing.Point(103, 114);
            this.panel7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(264, 33);
            this.panel7.TabIndex = 16;
            // 
            // CREATE_dropdown_scope
            // 
            this.CREATE_dropdown_scope.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CREATE_dropdown_scope.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CREATE_dropdown_scope.FormattingEnabled = true;
            this.CREATE_dropdown_scope.Location = new System.Drawing.Point(4, 4);
            this.CREATE_dropdown_scope.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CREATE_dropdown_scope.Name = "CREATE_dropdown_scope";
            this.CREATE_dropdown_scope.Size = new System.Drawing.Size(255, 24);
            this.CREATE_dropdown_scope.TabIndex = 13;
            this.CREATE_dropdown_scope.SelectedValueChanged += new System.EventHandler(this.CREATE_dropdown_scope_SelectedValueChanged);
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.CREATE_dropdown_file);
            this.panel8.Location = new System.Drawing.Point(103, 171);
            this.panel8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(264, 33);
            this.panel8.TabIndex = 17;
            // 
            // CREATE_dropdown_file
            // 
            this.CREATE_dropdown_file.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CREATE_dropdown_file.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CREATE_dropdown_file.FormattingEnabled = true;
            this.CREATE_dropdown_file.Items.AddRange(new object[] {
            "classchanges"});
            this.CREATE_dropdown_file.Location = new System.Drawing.Point(4, 4);
            this.CREATE_dropdown_file.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CREATE_dropdown_file.Name = "CREATE_dropdown_file";
            this.CREATE_dropdown_file.Size = new System.Drawing.Size(255, 24);
            this.CREATE_dropdown_file.TabIndex = 14;
            this.CREATE_dropdown_file.SelectedValueChanged += new System.EventHandler(this.CREATE_dropdown_file_SelectedValueChanged);
            // 
            // Read
            // 
            this.Read.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Read.Controls.Add(this.panel2);
            this.Read.Location = new System.Drawing.Point(4, 25);
            this.Read.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Read.Name = "Read";
            this.Read.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Read.Size = new System.Drawing.Size(675, 356);
            this.Read.TabIndex = 0;
            this.Read.Text = "Read";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panel2.Controls.Add(this.READ_labelval_desc);
            this.panel2.Controls.Add(this.READ_labelval_file);
            this.panel2.Controls.Add(this.READ_labelval_scope);
            this.panel2.Controls.Add(this.READ_labelval_type);
            this.panel2.Controls.Add(this.READ_labelval_name);
            this.panel2.Controls.Add(this.REGEX_labeldesc);
            this.panel2.Controls.Add(this.READ_labelfile);
            this.panel2.Controls.Add(this.READ_labelregex);
            this.panel2.Controls.Add(this.READ_labelType);
            this.panel2.Controls.Add(this.READ_labelName);
            this.panel2.Location = new System.Drawing.Point(5, 6);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(663, 345);
            this.panel2.TabIndex = 0;
            // 
            // READ_labelval_desc
            // 
            this.READ_labelval_desc.BackColor = System.Drawing.Color.White;
            this.READ_labelval_desc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.READ_labelval_desc.Location = new System.Drawing.Point(103, 226);
            this.READ_labelval_desc.Name = "READ_labelval_desc";
            this.READ_labelval_desc.Size = new System.Drawing.Size(517, 87);
            this.READ_labelval_desc.TabIndex = 9;
            this.READ_labelval_desc.Text = "No action selected";
            // 
            // READ_labelval_file
            // 
            this.READ_labelval_file.AutoSize = true;
            this.READ_labelval_file.BackColor = System.Drawing.Color.White;
            this.READ_labelval_file.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.READ_labelval_file.Location = new System.Drawing.Point(103, 178);
            this.READ_labelval_file.Name = "READ_labelval_file";
            this.READ_labelval_file.Size = new System.Drawing.Size(127, 19);
            this.READ_labelval_file.TabIndex = 8;
            this.READ_labelval_file.Text = "No action selected";
            // 
            // READ_labelval_scope
            // 
            this.READ_labelval_scope.AutoSize = true;
            this.READ_labelval_scope.BackColor = System.Drawing.Color.White;
            this.READ_labelval_scope.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.READ_labelval_scope.Location = new System.Drawing.Point(103, 122);
            this.READ_labelval_scope.Name = "READ_labelval_scope";
            this.READ_labelval_scope.Size = new System.Drawing.Size(127, 19);
            this.READ_labelval_scope.TabIndex = 7;
            this.READ_labelval_scope.Text = "No action selected";
            // 
            // READ_labelval_type
            // 
            this.READ_labelval_type.AutoSize = true;
            this.READ_labelval_type.BackColor = System.Drawing.Color.White;
            this.READ_labelval_type.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.READ_labelval_type.Location = new System.Drawing.Point(103, 70);
            this.READ_labelval_type.Name = "READ_labelval_type";
            this.READ_labelval_type.Size = new System.Drawing.Size(127, 19);
            this.READ_labelval_type.TabIndex = 6;
            this.READ_labelval_type.Text = "No action selected";
            // 
            // READ_labelval_name
            // 
            this.READ_labelval_name.AutoSize = true;
            this.READ_labelval_name.BackColor = System.Drawing.Color.White;
            this.READ_labelval_name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.READ_labelval_name.Location = new System.Drawing.Point(103, 21);
            this.READ_labelval_name.Name = "READ_labelval_name";
            this.READ_labelval_name.Size = new System.Drawing.Size(127, 19);
            this.READ_labelval_name.TabIndex = 5;
            this.READ_labelval_name.Text = "No action selected";
            // 
            // REGEX_labeldesc
            // 
            this.REGEX_labeldesc.AutoSize = true;
            this.REGEX_labeldesc.Cursor = System.Windows.Forms.Cursors.Help;
            this.REGEX_labeldesc.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.REGEX_labeldesc.Location = new System.Drawing.Point(16, 224);
            this.REGEX_labeldesc.Name = "REGEX_labeldesc";
            this.REGEX_labeldesc.Size = new System.Drawing.Size(63, 20);
            this.REGEX_labeldesc.TabIndex = 4;
            this.REGEX_labeldesc.Text = "About:";
            this.toolTip1.SetToolTip(this.REGEX_labeldesc, "a description of your action");
            // 
            // READ_labelfile
            // 
            this.READ_labelfile.AutoSize = true;
            this.READ_labelfile.Cursor = System.Windows.Forms.Cursors.Help;
            this.READ_labelfile.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.READ_labelfile.Location = new System.Drawing.Point(25, 175);
            this.READ_labelfile.Name = "READ_labelfile";
            this.READ_labelfile.Size = new System.Drawing.Size(54, 20);
            this.READ_labelfile.TabIndex = 3;
            this.READ_labelfile.Text = "File:";
            this.toolTip1.SetToolTip(this.READ_labelfile, "To create a new file close this window and select \'Content\' under \'Edit\'\r\nCreate " +
        "your own .json file to have it added it to this list");
            // 
            // READ_labelregex
            // 
            this.READ_labelregex.AutoSize = true;
            this.READ_labelregex.Cursor = System.Windows.Forms.Cursors.Help;
            this.READ_labelregex.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.READ_labelregex.Location = new System.Drawing.Point(16, 119);
            this.READ_labelregex.Name = "READ_labelregex";
            this.READ_labelregex.Size = new System.Drawing.Size(63, 20);
            this.READ_labelregex.TabIndex = 2;
            this.READ_labelregex.Text = "Scope:";
            this.toolTip1.SetToolTip(this.READ_labelregex, "Where the action will be taking place");
            // 
            // READ_labelType
            // 
            this.READ_labelType.AutoSize = true;
            this.READ_labelType.Cursor = System.Windows.Forms.Cursors.Help;
            this.READ_labelType.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.READ_labelType.Location = new System.Drawing.Point(25, 66);
            this.READ_labelType.Name = "READ_labelType";
            this.READ_labelType.Size = new System.Drawing.Size(54, 20);
            this.READ_labelType.TabIndex = 1;
            this.READ_labelType.Text = "Type:";
            this.toolTip1.SetToolTip(this.READ_labelType, "built-in function");
            // 
            // READ_labelName
            // 
            this.READ_labelName.AutoSize = true;
            this.READ_labelName.Cursor = System.Windows.Forms.Cursors.Help;
            this.READ_labelName.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.READ_labelName.Location = new System.Drawing.Point(25, 18);
            this.READ_labelName.Name = "READ_labelName";
            this.READ_labelName.Size = new System.Drawing.Size(54, 20);
            this.READ_labelName.TabIndex = 0;
            this.READ_labelName.Text = "Name:";
            this.toolTip1.SetToolTip(this.READ_labelName, "A simple name to describe your action");
            // 
            // tabsCRUD
            // 
            this.tabsCRUD.Controls.Add(this.Read);
            this.tabsCRUD.Controls.Add(this.Create);
            this.tabsCRUD.Controls.Add(this.Edit);
            this.tabsCRUD.Controls.Add(this.Delete);
            this.tabsCRUD.Location = new System.Drawing.Point(207, 12);
            this.tabsCRUD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabsCRUD.Name = "tabsCRUD";
            this.tabsCRUD.SelectedIndex = 0;
            this.tabsCRUD.Size = new System.Drawing.Size(683, 385);
            this.tabsCRUD.TabIndex = 7;
            // 
            // CRUD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(901, 409);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tabsCRUD);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CRUD";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit Actions";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CreateAction_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.Delete.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.Edit.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.panel11.ResumeLayout(false);
            this.Create.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.Read.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tabsCRUD.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox listActions;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabPage Delete;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TabPage Edit;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TabPage Create;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TabPage Read;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label READ_labelval_desc;
        private System.Windows.Forms.Label READ_labelval_file;
        private System.Windows.Forms.Label READ_labelval_scope;
        private System.Windows.Forms.Label READ_labelval_type;
        private System.Windows.Forms.Label READ_labelval_name;
        private System.Windows.Forms.Label REGEX_labeldesc;
        private System.Windows.Forms.Label READ_labelfile;
        private System.Windows.Forms.Label READ_labelregex;
        private System.Windows.Forms.Label READ_labelType;
        private System.Windows.Forms.Label READ_labelName;
        private System.Windows.Forms.TabControl tabsCRUD;
        private System.Windows.Forms.TextBox EDIT_textbox_description;
        private System.Windows.Forms.TextBox EDIT_textbox_name;
        private System.Windows.Forms.ComboBox EDIT_file_dropdown;
        private System.Windows.Forms.ComboBox EDIT_scope_dropdown;
        private System.Windows.Forms.ComboBox EDIT_type_dropdown;
        private System.Windows.Forms.ComboBox CREATE_dropdown_file;
        private System.Windows.Forms.ComboBox CREATE_dropdown_scope;
        private System.Windows.Forms.ComboBox CREATE_dropdown_type;
        private System.Windows.Forms.TextBox CREATE_textbox_description;
        private System.Windows.Forms.TextBox CREATE_textbox_name;
        private System.Windows.Forms.Label DELETE_label_name;
        private System.Windows.Forms.Button DELETE_button;
        private System.Windows.Forms.Button EDIT_button_save;
        private System.Windows.Forms.Button CREATE_button_save;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Label CREATE_about_type_label;
        private System.Windows.Forms.Label EDIT_about_type_label;
        private System.Windows.Forms.Label DELETE_label_desc;
    }
}