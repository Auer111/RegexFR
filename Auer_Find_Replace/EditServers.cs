using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Net;

namespace Auer_Find_Replace
{
    public partial class EditServers : Form
    {
        Auer_Find_Replace AFR;
        public EditServers(Auer_Find_Replace afr)
        {
            AFR = afr;
            InitializeComponent();
            Show();
            Setup();
        }

        private void Setup()
        {
            List<string> UNCpaths = Auer_Find_Replace.allPaths.Where(p => p.StartsWith("\\\\")).ToList();
            UNCpaths.ForEach(p => Paths_dataGridView.Rows.Add(NewRow(p)));
            ConnectionStatus();
            CheckCredentials();
        }

        public void CheckCredentials()
        {
            if(NetworkConnection._networkCredential.UserName.ToString().Length < 2 || NetworkConnection._networkCredential.Password.ToString().Length < 2)
            {
                NetworkCredential nc = PromptCredentials.ShowDialog("SA Credentials");
                if(nc == null) { CloseWindow(200); }
                else { NetworkConnection._networkCredential = nc; }
            }
        }

        private async void CloseWindow(int delay = 0)
        {
            AFR.OnWindowRefocus();
            await Task.Delay(delay);
            Close();
        }

        private DataGridViewRow NewRow(string path) {
            DataGridViewRow row = new DataGridViewRow();
            row.CreateCells(Paths_dataGridView);
            row.Cells[0].Value = path;
            row.Cells[1].Value = "Waiting...";
            return row;
        }

        private void EditServers_FormClosing(object sender, FormClosingEventArgs e){AFR.OnWindowRefocus();}

        private void connect_Click(object sender, EventArgs e)
        {
            Enabled = false;
            foreach (DataGridViewRow row in Paths_dataGridView.SelectedRows)
            {
                if (row.Cells[1].Value != null && row.Cells[1].Value.ToString() != "open")
                {
                    NetworkConnection.CreateConnection(row.Cells[0].Value.ToString());
                }
            }
            ConnectionStatus();
            Enabled = true;
        }

        private void Refresh_button_Click(object sender, EventArgs e)
        {
            ConnectionStatus();
        }

        private void ConnectionStatus() 
        {
            Enabled = false;
            foreach (DataGridViewRow row in Paths_dataGridView.Rows)
            {
                if (row.Cells[0].Value != null){row.Cells[1].Value = "...waiting"; }
            }
            foreach (DataGridViewRow row in Paths_dataGridView.Rows)
            {
                if (row.Cells[0].Value != null)
                {
                    bool valid = DataManager.PossiblePath(row.Cells[0].Value.ToString().Trim());
                    if (valid) { row.Cells[1].Value = "open"; } 
                    else { row.Cells[1].Value = "closed"; }
                }
            }
            Enabled = true;
        }

        private void connect_all_Click(object sender, EventArgs e)
        {
            Enabled = false;
            NetworkConnection.GenerateConnections();
            ConnectionStatus();
            Enabled = true;
        }

        private void Disconnect_all_Click(object sender, EventArgs e)
        {
            CMD cmd = new CMD();
            List<string> openConnections = cmd.GetPathsFromOutput(cmd.Run(CMD.Commands.OpenConnections));
            
            foreach (DataGridViewRow row in Paths_dataGridView.Rows)
            {
                if (row.Cells[0].Value != null)
                {
                    if (openConnections.Any(oc => oc.Trim() == row.Cells[0].Value.ToString().Trim())) {  cmd.Run(CMD.Commands.Close, row.Cells[0].Value.ToString().Trim()); }
                }
            }
            ConnectionStatus();
        }

        private void disconnect_Click(object sender, EventArgs e)
        {
            CMD cmd = new CMD();
            List<string> openConnections = cmd.GetPathsFromOutput(cmd.Run(CMD.Commands.OpenConnections));


            foreach (DataGridViewRow row in Paths_dataGridView.SelectedRows)
            {
                if (row.Cells[0].Value != null)
                {
                    if (openConnections.Any(oc => oc.Trim() == row.Cells[0].Value.ToString().Trim())) { cmd.Run(CMD.Commands.Close, row.Cells[0].Value.ToString().Trim()); }
                }
            }
            ConnectionStatus();
        }

        private void save_account_Click(object sender, EventArgs e)
        {
            NetworkCredential nc = PromptCredentials.ShowDialog("SA Credentials");
            if (nc != null) { NetworkConnection._networkCredential = nc; } 
        }

        private void EditServers_Enter(object sender, EventArgs e)
        {
            ConnectionStatus();
        }
    }
}
