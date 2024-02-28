namespace Database
{
    partial class FormData
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
            this.toolStripMenuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.TextBoxServer = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TextBoxLogin = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TextBoxPassword = new System.Windows.Forms.TextBox();
            this.CheckBoxTrustedConnection = new System.Windows.Forms.CheckBox();
            this.ButtonTestServerConnection = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.TextBoxDatabase = new System.Windows.Forms.TextBox();
            this.ButtonCreateDatabase = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.TabPageServer = new System.Windows.Forms.TabPage();
            this.TabPageDatabase = new System.Windows.Forms.TabPage();
            this.ButtonListDatabase = new System.Windows.Forms.Button();
            this.ListBoxDatabase = new System.Windows.Forms.ListBox();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.TabPageServer.SuspendLayout();
            this.TabPageDatabase.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuFile});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(323, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuFile
            // 
            this.toolStripMenuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuExit});
            this.toolStripMenuFile.Name = "toolStripMenuFile";
            this.toolStripMenuFile.Size = new System.Drawing.Size(37, 20);
            this.toolStripMenuFile.Text = "&File";
            // 
            // toolStripMenuExit
            // 
            this.toolStripMenuExit.Name = "toolStripMenuExit";
            this.toolStripMenuExit.Size = new System.Drawing.Size(93, 22);
            this.toolStripMenuExit.Text = "&Exit";
            this.toolStripMenuExit.Click += new System.EventHandler(this.toolStripMenuExit_Click);
            // 
            // TextBoxServer
            // 
            this.TextBoxServer.Location = new System.Drawing.Point(45, 71);
            this.TextBoxServer.Name = "TextBoxServer";
            this.TextBoxServer.Size = new System.Drawing.Size(183, 22);
            this.TextBoxServer.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Address";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Login";
            // 
            // TextBoxLogin
            // 
            this.TextBoxLogin.Location = new System.Drawing.Point(45, 128);
            this.TextBoxLogin.Name = "TextBoxLogin";
            this.TextBoxLogin.Size = new System.Drawing.Size(183, 22);
            this.TextBoxLogin.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Password";
            // 
            // TextBoxPassword
            // 
            this.TextBoxPassword.Location = new System.Drawing.Point(45, 170);
            this.TextBoxPassword.Name = "TextBoxPassword";
            this.TextBoxPassword.Size = new System.Drawing.Size(183, 22);
            this.TextBoxPassword.TabIndex = 7;
            // 
            // CheckBoxTrustedConnection
            // 
            this.CheckBoxTrustedConnection.AutoSize = true;
            this.CheckBoxTrustedConnection.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckBoxTrustedConnection.Location = new System.Drawing.Point(48, 206);
            this.CheckBoxTrustedConnection.Name = "CheckBoxTrustedConnection";
            this.CheckBoxTrustedConnection.Size = new System.Drawing.Size(142, 20);
            this.CheckBoxTrustedConnection.TabIndex = 10;
            this.CheckBoxTrustedConnection.Text = "Trusted Connection";
            this.CheckBoxTrustedConnection.UseVisualStyleBackColor = true;
            this.CheckBoxTrustedConnection.CheckedChanged += new System.EventHandler(this.CheckBoxTrustedConnection_CheckedChanged);
            // 
            // ButtonTestServerConnection
            // 
            this.ButtonTestServerConnection.Location = new System.Drawing.Point(48, 240);
            this.ButtonTestServerConnection.Name = "ButtonTestServerConnection";
            this.ButtonTestServerConnection.Size = new System.Drawing.Size(180, 23);
            this.ButtonTestServerConnection.TabIndex = 9;
            this.ButtonTestServerConnection.Text = "Test";
            this.ButtonTestServerConnection.UseVisualStyleBackColor = true;
            this.ButtonTestServerConnection.Click += new System.EventHandler(this.ButtonTestServerConnection_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 230);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Name";
            // 
            // TextBoxDatabase
            // 
            this.TextBoxDatabase.Location = new System.Drawing.Point(39, 249);
            this.TextBoxDatabase.Name = "TextBoxDatabase";
            this.TextBoxDatabase.Size = new System.Drawing.Size(183, 22);
            this.TextBoxDatabase.TabIndex = 3;
            // 
            // ButtonCreateDatabase
            // 
            this.ButtonCreateDatabase.Location = new System.Drawing.Point(39, 277);
            this.ButtonCreateDatabase.Name = "ButtonCreateDatabase";
            this.ButtonCreateDatabase.Size = new System.Drawing.Size(183, 23);
            this.ButtonCreateDatabase.TabIndex = 10;
            this.ButtonCreateDatabase.Text = "Create";
            this.ButtonCreateDatabase.UseVisualStyleBackColor = true;
            this.ButtonCreateDatabase.Click += new System.EventHandler(this.ButtonCreateDatabase_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.TabPageServer);
            this.tabControl1.Controls.Add(this.TabPageDatabase);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(21, 43);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(281, 344);
            this.tabControl1.TabIndex = 11;
            // 
            // TabPageServer
            // 
            this.TabPageServer.Controls.Add(this.CheckBoxTrustedConnection);
            this.TabPageServer.Controls.Add(this.ButtonTestServerConnection);
            this.TabPageServer.Controls.Add(this.label2);
            this.TabPageServer.Controls.Add(this.label1);
            this.TabPageServer.Controls.Add(this.TextBoxLogin);
            this.TabPageServer.Controls.Add(this.label3);
            this.TabPageServer.Controls.Add(this.TextBoxPassword);
            this.TabPageServer.Controls.Add(this.TextBoxServer);
            this.TabPageServer.Location = new System.Drawing.Point(4, 25);
            this.TabPageServer.Name = "TabPageServer";
            this.TabPageServer.Padding = new System.Windows.Forms.Padding(3);
            this.TabPageServer.Size = new System.Drawing.Size(273, 315);
            this.TabPageServer.TabIndex = 0;
            this.TabPageServer.Text = "Server";
            this.TabPageServer.UseVisualStyleBackColor = true;
            // 
            // TabPageDatabase
            // 
            this.TabPageDatabase.Controls.Add(this.ButtonListDatabase);
            this.TabPageDatabase.Controls.Add(this.ListBoxDatabase);
            this.TabPageDatabase.Controls.Add(this.ButtonCreateDatabase);
            this.TabPageDatabase.Controls.Add(this.label4);
            this.TabPageDatabase.Controls.Add(this.TextBoxDatabase);
            this.TabPageDatabase.Location = new System.Drawing.Point(4, 25);
            this.TabPageDatabase.Name = "TabPageDatabase";
            this.TabPageDatabase.Padding = new System.Windows.Forms.Padding(3);
            this.TabPageDatabase.Size = new System.Drawing.Size(273, 315);
            this.TabPageDatabase.TabIndex = 1;
            this.TabPageDatabase.Text = "Database";
            this.TabPageDatabase.UseVisualStyleBackColor = true;
            // 
            // ButtonListDatabase
            // 
            this.ButtonListDatabase.Location = new System.Drawing.Point(39, 169);
            this.ButtonListDatabase.Name = "ButtonListDatabase";
            this.ButtonListDatabase.Size = new System.Drawing.Size(183, 23);
            this.ButtonListDatabase.TabIndex = 12;
            this.ButtonListDatabase.Text = "List";
            this.ButtonListDatabase.UseVisualStyleBackColor = true;
            this.ButtonListDatabase.Click += new System.EventHandler(this.ButtonListDatabase_Click);
            // 
            // ListBoxDatabase
            // 
            this.ListBoxDatabase.FormattingEnabled = true;
            this.ListBoxDatabase.ItemHeight = 16;
            this.ListBoxDatabase.Location = new System.Drawing.Point(39, 15);
            this.ListBoxDatabase.Name = "ListBoxDatabase";
            this.ListBoxDatabase.Size = new System.Drawing.Size(183, 148);
            this.ListBoxDatabase.TabIndex = 11;
            // 
            // FormDatabase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 431);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormDatabase";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Database Manager";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.TabPageServer.ResumeLayout(false);
            this.TabPageServer.PerformLayout();
            this.TabPageDatabase.ResumeLayout(false);
            this.TabPageDatabase.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuFile;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuExit;
        private System.Windows.Forms.TextBox TextBoxServer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TextBoxLogin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TextBoxPassword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TextBoxDatabase;
        private System.Windows.Forms.Button ButtonTestServerConnection;
        private System.Windows.Forms.CheckBox CheckBoxTrustedConnection;
        private System.Windows.Forms.Button ButtonCreateDatabase;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage TabPageServer;
        private System.Windows.Forms.TabPage TabPageDatabase;
        private System.Windows.Forms.Button ButtonListDatabase;
        private System.Windows.Forms.ListBox ListBoxDatabase;
    }
}