namespace Auer_Find_Replace
{
    partial class EditPaths
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
            this.Paths_dataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EDIT_button_save = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.Paths_button_exclude = new System.Windows.Forms.Button();
            this.Paths_Status_checkbox = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.Extensions_button_exclude = new System.Windows.Forms.Button();
            this.Extensions_Status_checkbox = new System.Windows.Forms.Label();
            this.EXTENSIONS_button_save = new System.Windows.Forms.Button();
            this.Extensions_dataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.Paths_dataGridView)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Extensions_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // Paths_dataGridView
            // 
            this.Paths_dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Paths_dataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.Paths_dataGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.Paths_dataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Paths_dataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.Paths_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Paths_dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1});
            this.Paths_dataGridView.Location = new System.Drawing.Point(4, 30);
            this.Paths_dataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.Paths_dataGridView.Name = "Paths_dataGridView";
            this.Paths_dataGridView.RowHeadersVisible = false;
            this.Paths_dataGridView.RowHeadersWidth = 51;
            this.Paths_dataGridView.RowTemplate.Height = 24;
            this.Paths_dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Paths_dataGridView.ShowCellErrors = false;
            this.Paths_dataGridView.ShowCellToolTips = false;
            this.Paths_dataGridView.ShowEditingIcon = false;
            this.Paths_dataGridView.ShowRowErrors = false;
            this.Paths_dataGridView.Size = new System.Drawing.Size(574, 287);
            this.Paths_dataGridView.TabIndex = 2;
            this.Paths_dataGridView.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.Paths_dataGridView_CellEndEdit);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Saved File Paths";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // EDIT_button_save
            // 
            this.EDIT_button_save.BackColor = System.Drawing.SystemColors.Control;
            this.EDIT_button_save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EDIT_button_save.Font = new System.Drawing.Font("Wingdings", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.EDIT_button_save.Location = new System.Drawing.Point(497, 4);
            this.EDIT_button_save.Margin = new System.Windows.Forms.Padding(2);
            this.EDIT_button_save.Name = "EDIT_button_save";
            this.EDIT_button_save.Size = new System.Drawing.Size(46, 25);
            this.EDIT_button_save.TabIndex = 19;
            this.EDIT_button_save.Text = "<";
            this.EDIT_button_save.UseVisualStyleBackColor = false;
            this.EDIT_button_save.Click += new System.EventHandler(this.FilePath_button_save_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(9, 10);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(590, 346);
            this.tabControl1.TabIndex = 20;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.Controls.Add(this.Paths_button_exclude);
            this.tabPage1.Controls.Add(this.Paths_Status_checkbox);
            this.tabPage1.Controls.Add(this.EDIT_button_save);
            this.tabPage1.Controls.Add(this.Paths_dataGridView);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage1.Size = new System.Drawing.Size(582, 320);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "File Paths";
            // 
            // Paths_button_exclude
            // 
            this.Paths_button_exclude.BackColor = System.Drawing.SystemColors.Control;
            this.Paths_button_exclude.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Paths_button_exclude.Font = new System.Drawing.Font("Wingdings 2", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.Paths_button_exclude.Location = new System.Drawing.Point(446, 4);
            this.Paths_button_exclude.Name = "Paths_button_exclude";
            this.Paths_button_exclude.Size = new System.Drawing.Size(46, 25);
            this.Paths_button_exclude.TabIndex = 26;
            this.Paths_button_exclude.Text = "3";
            this.Paths_button_exclude.UseVisualStyleBackColor = false;
            this.Paths_button_exclude.Click += new System.EventHandler(this.Paths_button_exclude_Click);
            // 
            // Paths_Status_checkbox
            // 
            this.Paths_Status_checkbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Paths_Status_checkbox.Font = new System.Drawing.Font("Wingdings 2", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.Paths_Status_checkbox.Location = new System.Drawing.Point(548, 4);
            this.Paths_Status_checkbox.Name = "Paths_Status_checkbox";
            this.Paths_Status_checkbox.Size = new System.Drawing.Size(24, 24);
            this.Paths_Status_checkbox.TabIndex = 25;
            this.Paths_Status_checkbox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage2.Controls.Add(this.Extensions_button_exclude);
            this.tabPage2.Controls.Add(this.Extensions_Status_checkbox);
            this.tabPage2.Controls.Add(this.EXTENSIONS_button_save);
            this.tabPage2.Controls.Add(this.Extensions_dataGridView);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage2.Size = new System.Drawing.Size(582, 320);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "File Extensions";
            // 
            // Extensions_button_exclude
            // 
            this.Extensions_button_exclude.BackColor = System.Drawing.SystemColors.Control;
            this.Extensions_button_exclude.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Extensions_button_exclude.Font = new System.Drawing.Font("Wingdings 2", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.Extensions_button_exclude.Location = new System.Drawing.Point(446, 4);
            this.Extensions_button_exclude.Name = "Extensions_button_exclude";
            this.Extensions_button_exclude.Size = new System.Drawing.Size(46, 25);
            this.Extensions_button_exclude.TabIndex = 25;
            this.Extensions_button_exclude.Text = "3";
            this.Extensions_button_exclude.UseVisualStyleBackColor = false;
            this.Extensions_button_exclude.Click += new System.EventHandler(this.Extensions_button_exclude_Click);
            // 
            // Extensions_Status_checkbox
            // 
            this.Extensions_Status_checkbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Extensions_Status_checkbox.Font = new System.Drawing.Font("Wingdings 2", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.Extensions_Status_checkbox.Location = new System.Drawing.Point(548, 4);
            this.Extensions_Status_checkbox.Name = "Extensions_Status_checkbox";
            this.Extensions_Status_checkbox.Size = new System.Drawing.Size(24, 24);
            this.Extensions_Status_checkbox.TabIndex = 24;
            this.Extensions_Status_checkbox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EXTENSIONS_button_save
            // 
            this.EXTENSIONS_button_save.BackColor = System.Drawing.SystemColors.Control;
            this.EXTENSIONS_button_save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EXTENSIONS_button_save.Font = new System.Drawing.Font("Wingdings", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.EXTENSIONS_button_save.Location = new System.Drawing.Point(497, 4);
            this.EXTENSIONS_button_save.Margin = new System.Windows.Forms.Padding(2);
            this.EXTENSIONS_button_save.Name = "EXTENSIONS_button_save";
            this.EXTENSIONS_button_save.Size = new System.Drawing.Size(46, 25);
            this.EXTENSIONS_button_save.TabIndex = 20;
            this.EXTENSIONS_button_save.Text = "<";
            this.EXTENSIONS_button_save.UseVisualStyleBackColor = false;
            this.EXTENSIONS_button_save.Click += new System.EventHandler(this.EXTENSIONS_button_save_Click);
            // 
            // Extensions_dataGridView
            // 
            this.Extensions_dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Extensions_dataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.Extensions_dataGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.Extensions_dataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Extensions_dataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.Extensions_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Extensions_dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2});
            this.Extensions_dataGridView.Location = new System.Drawing.Point(4, 30);
            this.Extensions_dataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.Extensions_dataGridView.Name = "Extensions_dataGridView";
            this.Extensions_dataGridView.RowHeadersVisible = false;
            this.Extensions_dataGridView.RowHeadersWidth = 51;
            this.Extensions_dataGridView.RowTemplate.Height = 24;
            this.Extensions_dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Extensions_dataGridView.ShowCellErrors = false;
            this.Extensions_dataGridView.ShowCellToolTips = false;
            this.Extensions_dataGridView.ShowEditingIcon = false;
            this.Extensions_dataGridView.ShowRowErrors = false;
            this.Extensions_dataGridView.Size = new System.Drawing.Size(574, 288);
            this.Extensions_dataGridView.TabIndex = 3;
            this.Extensions_dataGridView.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.Extensions_dataGridView_CellEndEdit);
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Saved File Extensions";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // EditPaths
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "EditPaths";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SavedPaths";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EditPaths_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.Paths_dataGridView)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Extensions_dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView Paths_dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.Button EDIT_button_save;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView Extensions_dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.Button EXTENSIONS_button_save;
        private System.Windows.Forms.Label Paths_Status_checkbox;
        private System.Windows.Forms.Label Extensions_Status_checkbox;
        private System.Windows.Forms.Button Paths_button_exclude;
        private System.Windows.Forms.Button Extensions_button_exclude;
    }
}