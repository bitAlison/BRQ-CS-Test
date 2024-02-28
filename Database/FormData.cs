using Database.Model;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Database
{
    public partial class FormData : Form
    {
        public FormData()
        {
            InitializeComponent();
        }

        private void toolStripMenuExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ButtonTestServerConnection_Click(object sender, EventArgs e)
        {
            var reqConn = new ConnectionRequest()
            {
                Server = this.TextBoxServer.Text,
                User__ID = this.TextBoxLogin.Text,
                Password = this.TextBoxPassword.Text,
                Trusted_Connection = this.CheckBoxTrustedConnection.Checked
            };

            var response = ServerManager.CheckServerConnection(reqConn);
            if (!response.Success)
            {
                MessageBox.Show(response.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Connection Success", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void CheckBoxTrustedConnection_CheckedChanged(object sender, EventArgs e)
        {
            if (((CheckBox)sender).Checked)
            {
                this.TextBoxLogin.Clear();
                this.TextBoxPassword.Clear();
                this.TextBoxLogin.Enabled = false;
                this.TextBoxPassword.Enabled = false;
            }
            else
            {
                this.TextBoxLogin.Enabled = true;
                this.TextBoxPassword.Enabled = true;
            }
        }

        private void ButtonCreateDatabase_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.TextBoxDatabase.Text))
            {
                MessageBox.Show("Database name cannot be null or empty");
                this.TextBoxDatabase.Focus();
                return;
            }

            var reqDatabase = new ConnectionRequest()
            {
                Server = this.TextBoxServer.Text,
                User__ID = this.TextBoxLogin.Text,
                Password = this.TextBoxPassword.Text,
                Trusted_Connection = this.CheckBoxTrustedConnection.Checked,
                Database = this.TextBoxDatabase.Text
            };

            var response = ServerManager.CreateDatabase(reqDatabase);
            if (!response.Success)
            {
                MessageBox.Show(response.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (response.Message.ToLower().Contains("server") || response.Message.ToLower().Contains("address"))
                {
                    this.tabControl1.SelectedIndex = 0;
                    this.TextBoxServer.Focus();
                }
            }
            else
            {
                ButtonListDatabase_Click(sender, new EventArgs());
                MessageBox.Show(response.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ButtonListDatabase_Click(object sender, EventArgs e)
        {
            var reqDatabase = new ConnectionRequest()
            {
                Server = this.TextBoxServer.Text,
                User__ID = this.TextBoxLogin.Text,
                Password = this.TextBoxPassword.Text,
                Trusted_Connection = this.CheckBoxTrustedConnection.Checked
            };

            var response = ServerManager.GetDatabaseList(reqDatabase);
            if (!response.Success)
            {
                MessageBox.Show(response.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (response.Message.ToLower().Contains("server") || response.Message.ToLower().Contains("address"))
                {
                    this.tabControl1.SelectedIndex = 0;
                    this.TextBoxServer.Focus();
                }
            }

            if (response.Data.GetType() == typeof(DatabaseModel[]))
            {
                PopulateDatabaseList(((DatabaseModel[])response.Data).Select(n => n.name).ToArray());
            }
        }

        private void PopulateDatabaseList(string[] Names)
        {
            this.ListBoxDatabase.Items.Clear();
            this.ListBoxDatabase.Items.AddRange(Names);
        }
    }
}
