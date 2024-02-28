using LibTrade.Contracts;
using LibTrade.Model;

using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsTrade
{
    public partial class FormMain : Form
    {
        private IList<ITrade> portfolio;
        private IList<string> tradeCategories;

        public FormMain()
        {
            InitializeComponent();
        }
        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void ButtonImport_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog()
            {
                AddExtension = true,
                DefaultExt = "json",
                Filter = "Json file|*.json",
                Multiselect = false,
                RestoreDirectory = true,
                Title = "Import data"
            };

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                portfolio = LibTrade.Extensions.JsonExtensions
                    .ToJson<TradeModel[]>(File.ReadAllText(ofd.FileName));

                this.DataGridViewInput.Rows.Clear();
                this.DataGridViewInput.DataSource = portfolio;

                tradeCategories = LibTrade.ChainsOfResponsibility
                    .Run(portfolio)
                    .Select(c => c.Category)
                    .ToList();

                this.DataGridViewOutput.Rows.Clear();

                if (this.DataGridViewOutput.Columns.Count == 0)
                {
                    this.DataGridViewOutput.Columns.Add("Category", "Category");
                }

                foreach (string category in tradeCategories)
                    this.DataGridViewOutput.Rows.Add(category);
            }
        }
        private void ButtonExport_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog()
            {
                AddExtension = true,
                DefaultExt = "json",
                OverwritePrompt = true,
                CheckPathExists = true,
                Filter = "Json file|*.json",
                RestoreDirectory = true,
                FileName = "output",
                Title = "Export data"
            };

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(sfd.FileName, "{\"" + string.Join("\",\"", tradeCategories) + "\"}");
                MessageBox.Show("File saved", "Export data", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Process.Start(Path.GetDirectoryName(sfd.FileName));
            }
        }

        private void SampleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog()
            {
                AddExtension = true,
                DefaultExt = "json",
                OverwritePrompt = true,
                CheckPathExists = true,
                Filter = "Json file|*.json",
                RestoreDirectory = true,
                FileName = "sample",
                Title = "Sample data"
            };
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                StringBuilder sb = new StringBuilder();
                sb.Append("[");

                Random rnd = new Random();
                for (int r = 0; r < 15; r++)
                {
                    sb.Append(string.Concat("{", "\"Value\":", rnd.Next(250000, 2500000), ",\"ClientSector\":\"", rnd.Next(0, 2) == 0 ? "Private" : "Public", "\"},"));
                }

                File.WriteAllText(sfd.FileName, sb.ToString().TrimEnd(new[] { ',' }) + "]");
                MessageBox.Show("Sample created", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                Process.Start(Path.GetDirectoryName(sfd.FileName));
            }
        }

        private void DatabaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Database.FormData().ShowDialog();
        }
    }
}
