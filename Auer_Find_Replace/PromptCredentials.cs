using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;

namespace Auer_Find_Replace
{
    class PromptCredentials
    {
        public static NetworkCredential ShowDialog(string caption)
        {
            Form prompt = new Form()
            {
                Width = 300,
                Height = 180,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                Text = caption,
                StartPosition = FormStartPosition.CenterScreen
            };

            NetworkCredential nc = NetworkConnection._networkCredential;

            Label utextLabel = new Label() { Left = 50, Top = 10, Width = 200, Text = "Username" };
            TextBox utextBox = new TextBox() { Left = 50, Top = 30, Width = 200, Text = nc.UserName == "" ?  "sa.first.last" : nc.UserName };

            Label ptextLabel = new Label() { Left = 50, Top = 60, Width = 200, Text = "Password" };
            TextBox ptextBox = new TextBox() { Left = 50, Top = 80, Width = 200, Text = nc.Password };
            Button cancel = new Button() { Text = "Cancel", Left = 30, Width = 100, Top = 110, DialogResult = DialogResult.Cancel};
            Button confirmation = new Button() { Text = "Submit", Left = 150, Width = 100, Top = 110, DialogResult = DialogResult.OK };
            confirmation.Click += (sender, e) => { prompt.Close(); };
            prompt.Controls.Add(utextBox);
            prompt.Controls.Add(utextLabel);
            prompt.Controls.Add(ptextBox);
            prompt.Controls.Add(ptextLabel);
            prompt.Controls.Add(cancel);
            prompt.Controls.Add(confirmation);
            prompt.CancelButton = cancel;
            prompt.AcceptButton = confirmation;

            return prompt.ShowDialog() ==  DialogResult.OK ? new NetworkCredential(utextBox.Text, ptextBox.Text) : null;
        }
    }
}
