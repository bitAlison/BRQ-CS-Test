namespace WindowsFormsTrade
{
    partial class FormMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.FileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SampleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.groupBoxInput = new System.Windows.Forms.GroupBox();
            this.DataGridViewInput = new System.Windows.Forms.DataGridView();
            this.ButtonImport = new System.Windows.Forms.Button();
            this.ButtonExport = new System.Windows.Forms.Button();
            this.groupBoxOutput = new System.Windows.Forms.GroupBox();
            this.DataGridViewOutput = new System.Windows.Forms.DataGridView();
            this.DatabaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.groupBoxInput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewInput)).BeginInit();
            this.groupBoxOutput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewOutput)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileToolStripMenuItem,
            this.SampleToolStripMenuItem,
            this.DatabaseToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(748, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // FileToolStripMenuItem
            // 
            this.FileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ExitToolStripMenuItem});
            this.FileToolStripMenuItem.Name = "FileToolStripMenuItem";
            this.FileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.FileToolStripMenuItem.Text = "&File";
            // 
            // ExitToolStripMenuItem
            // 
            this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            this.ExitToolStripMenuItem.Size = new System.Drawing.Size(93, 22);
            this.ExitToolStripMenuItem.Text = "&Exit";
            this.ExitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // SampleToolStripMenuItem
            // 
            this.SampleToolStripMenuItem.Name = "SampleToolStripMenuItem";
            this.SampleToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.SampleToolStripMenuItem.Text = "&Sample";
            this.SampleToolStripMenuItem.Click += new System.EventHandler(this.SampleToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(748, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // groupBoxInput
            // 
            this.groupBoxInput.Controls.Add(this.DataGridViewInput);
            this.groupBoxInput.Location = new System.Drawing.Point(17, 39);
            this.groupBoxInput.Name = "groupBoxInput";
            this.groupBoxInput.Size = new System.Drawing.Size(350, 345);
            this.groupBoxInput.TabIndex = 2;
            this.groupBoxInput.TabStop = false;
            this.groupBoxInput.Text = "Input";
            // 
            // DataGridViewInput
            // 
            this.DataGridViewInput.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewInput.Location = new System.Drawing.Point(6, 19);
            this.DataGridViewInput.MultiSelect = false;
            this.DataGridViewInput.Name = "DataGridViewInput";
            this.DataGridViewInput.ReadOnly = true;
            this.DataGridViewInput.RowHeadersVisible = false;
            this.DataGridViewInput.Size = new System.Drawing.Size(338, 320);
            this.DataGridViewInput.TabIndex = 0;
            // 
            // ButtonImport
            // 
            this.ButtonImport.Location = new System.Drawing.Point(286, 384);
            this.ButtonImport.Name = "ButtonImport";
            this.ButtonImport.Size = new System.Drawing.Size(75, 23);
            this.ButtonImport.TabIndex = 3;
            this.ButtonImport.Text = "Import";
            this.ButtonImport.UseVisualStyleBackColor = true;
            this.ButtonImport.Click += new System.EventHandler(this.ButtonImport_Click);
            // 
            // ButtonExport
            // 
            this.ButtonExport.Location = new System.Drawing.Point(651, 384);
            this.ButtonExport.Name = "ButtonExport";
            this.ButtonExport.Size = new System.Drawing.Size(75, 23);
            this.ButtonExport.TabIndex = 5;
            this.ButtonExport.Text = "Export";
            this.ButtonExport.UseVisualStyleBackColor = true;
            this.ButtonExport.Click += new System.EventHandler(this.ButtonExport_Click);
            // 
            // groupBoxOutput
            // 
            this.groupBoxOutput.Controls.Add(this.DataGridViewOutput);
            this.groupBoxOutput.Location = new System.Drawing.Point(382, 39);
            this.groupBoxOutput.Name = "groupBoxOutput";
            this.groupBoxOutput.Size = new System.Drawing.Size(350, 345);
            this.groupBoxOutput.TabIndex = 4;
            this.groupBoxOutput.TabStop = false;
            this.groupBoxOutput.Text = "Output";
            // 
            // DataGridViewOutput
            // 
            this.DataGridViewOutput.AllowUserToAddRows = false;
            this.DataGridViewOutput.AllowUserToDeleteRows = false;
            this.DataGridViewOutput.AllowUserToOrderColumns = true;
            this.DataGridViewOutput.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewOutput.Location = new System.Drawing.Point(6, 19);
            this.DataGridViewOutput.MultiSelect = false;
            this.DataGridViewOutput.Name = "DataGridViewOutput";
            this.DataGridViewOutput.ReadOnly = true;
            this.DataGridViewOutput.RowHeadersVisible = false;
            this.DataGridViewOutput.Size = new System.Drawing.Size(338, 320);
            this.DataGridViewOutput.TabIndex = 0;
            // 
            // DatabaseToolStripMenuItem
            // 
            this.DatabaseToolStripMenuItem.Name = "DatabaseToolStripMenuItem";
            this.DatabaseToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.DatabaseToolStripMenuItem.Text = "&Database";
            this.DatabaseToolStripMenuItem.Click += new System.EventHandler(this.DatabaseToolStripMenuItem_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 450);
            this.Controls.Add(this.ButtonExport);
            this.Controls.Add(this.groupBoxOutput);
            this.Controls.Add(this.ButtonImport);
            this.Controls.Add(this.groupBoxInput);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBoxInput.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewInput)).EndInit();
            this.groupBoxOutput.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewOutput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem FileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ExitToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.GroupBox groupBoxInput;
        private System.Windows.Forms.DataGridView DataGridViewInput;
        private System.Windows.Forms.Button ButtonImport;
        private System.Windows.Forms.Button ButtonExport;
        private System.Windows.Forms.GroupBox groupBoxOutput;
        private System.Windows.Forms.DataGridView DataGridViewOutput;
        private System.Windows.Forms.ToolStripMenuItem SampleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DatabaseToolStripMenuItem;
    }
}

