namespace Auer_Find_Replace
{
    partial class EditServers
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
            this.Paths_dataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.State = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.connect = new System.Windows.Forms.Button();
            this.Refresh_button = new System.Windows.Forms.Button();
            this.connect_all = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Disconnect_all = new System.Windows.Forms.Button();
            this.disconnect = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.save_account = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Paths_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // Paths_dataGridView
            // 
            this.Paths_dataGridView.AllowUserToAddRows = false;
            this.Paths_dataGridView.AllowUserToDeleteRows = false;
            this.Paths_dataGridView.AllowUserToResizeColumns = false;
            this.Paths_dataGridView.AllowUserToResizeRows = false;
            this.Paths_dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Paths_dataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.Paths_dataGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.Paths_dataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Paths_dataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.Paths_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Paths_dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.State});
            this.Paths_dataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.Paths_dataGridView.Location = new System.Drawing.Point(10, 11);
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
            this.Paths_dataGridView.Size = new System.Drawing.Size(778, 362);
            this.Paths_dataGridView.TabIndex = 3;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Server UNC Path";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 2;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // State
            // 
            this.State.FillWeight = 25F;
            this.State.HeaderText = "Connection State";
            this.State.MinimumWidth = 8;
            this.State.Name = "State";
            this.State.ReadOnly = true;
            this.State.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.State.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // connect
            // 
            this.connect.Location = new System.Drawing.Point(529, 413);
            this.connect.Name = "connect";
            this.connect.Size = new System.Drawing.Size(67, 28);
            this.connect.TabIndex = 4;
            this.connect.Text = "Selected";
            this.connect.UseVisualStyleBackColor = true;
            this.connect.Click += new System.EventHandler(this.connect_Click);
            // 
            // Refresh_button
            // 
            this.Refresh_button.Font = new System.Drawing.Font("Wingdings 3", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.Refresh_button.Location = new System.Drawing.Point(602, 390);
            this.Refresh_button.Name = "Refresh_button";
            this.Refresh_button.Size = new System.Drawing.Size(52, 51);
            this.Refresh_button.TabIndex = 5;
            this.Refresh_button.Text = "P";
            this.toolTip1.SetToolTip(this.Refresh_button, "Refresh Status");
            this.Refresh_button.UseVisualStyleBackColor = true;
            this.Refresh_button.Click += new System.EventHandler(this.Refresh_button_Click);
            // 
            // connect_all
            // 
            this.connect_all.Location = new System.Drawing.Point(466, 413);
            this.connect_all.Name = "connect_all";
            this.connect_all.Size = new System.Drawing.Size(59, 28);
            this.connect_all.TabIndex = 6;
            this.connect_all.Text = "All";
            this.connect_all.UseVisualStyleBackColor = true;
            this.connect_all.Click += new System.EventHandler(this.connect_all_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(500, 387);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Connect to:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(466, 403);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(130, 4);
            this.panel1.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(660, 403);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(130, 4);
            this.panel2.TabIndex = 9;
            // 
            // Disconnect_all
            // 
            this.Disconnect_all.Location = new System.Drawing.Point(660, 413);
            this.Disconnect_all.Name = "Disconnect_all";
            this.Disconnect_all.Size = new System.Drawing.Size(59, 28);
            this.Disconnect_all.TabIndex = 10;
            this.Disconnect_all.Text = "All";
            this.Disconnect_all.UseVisualStyleBackColor = true;
            this.Disconnect_all.Click += new System.EventHandler(this.Disconnect_all_Click);
            // 
            // disconnect
            // 
            this.disconnect.Location = new System.Drawing.Point(723, 413);
            this.disconnect.Name = "disconnect";
            this.disconnect.Size = new System.Drawing.Size(67, 28);
            this.disconnect.TabIndex = 11;
            this.disconnect.Text = "Selected";
            this.disconnect.UseVisualStyleBackColor = true;
            this.disconnect.Click += new System.EventHandler(this.disconnect_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(683, 387);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Disconnect From:";
            // 
            // save_account
            // 
            this.save_account.Font = new System.Drawing.Font("Webdings", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.save_account.Location = new System.Drawing.Point(10, 390);
            this.save_account.Name = "save_account";
            this.save_account.Size = new System.Drawing.Size(52, 51);
            this.save_account.TabIndex = 15;
            this.save_account.Text = "d";
            this.toolTip1.SetToolTip(this.save_account, "SA Account");
            this.save_account.UseVisualStyleBackColor = true;
            this.save_account.Click += new System.EventHandler(this.save_account_Click);
            // 
            // EditServers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.save_account);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.disconnect);
            this.Controls.Add(this.Disconnect_all);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.connect_all);
            this.Controls.Add(this.Refresh_button);
            this.Controls.Add(this.connect);
            this.Controls.Add(this.Paths_dataGridView);
            this.Name = "EditServers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditServers";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EditServers_FormClosing);
            this.Enter += new System.EventHandler(this.EditServers_Enter);
            ((System.ComponentModel.ISupportInitialize)(this.Paths_dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Paths_dataGridView;
        private System.Windows.Forms.Button connect;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn State;
        private System.Windows.Forms.Button Refresh_button;
        private System.Windows.Forms.Button connect_all;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button Disconnect_all;
        private System.Windows.Forms.Button disconnect;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button save_account;
    }
}