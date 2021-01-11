namespace SystemTrayNotification
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.notifyIconTray = new System.Windows.Forms.NotifyIcon(this.components);
            this.process1 = new System.Diagnostics.Process();
            this.btnExit = new System.Windows.Forms.Button();
            this.tabCenter = new System.Windows.Forms.TabControl();
            this.tabWords = new System.Windows.Forms.TabPage();
            this.txtOutputWords = new System.Windows.Forms.TextBox();
            this.txtInputWords = new System.Windows.Forms.TextBox();
            this.tabPadel = new System.Windows.Forms.TabPage();
            this.txtOutputPadel = new System.Windows.Forms.TextBox();
            this.txtInputPadel = new System.Windows.Forms.TextBox();
            this.tabCenter.SuspendLayout();
            this.tabWords.SuspendLayout();
            this.tabPadel.SuspendLayout();
            this.SuspendLayout();
            // 
            // notifyIconTray
            // 
            this.notifyIconTray.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIconTray.Icon")));
            this.notifyIconTray.Text = "notifyIcon1";
            this.notifyIconTray.Visible = true;
            this.notifyIconTray.DoubleClick += new System.EventHandler(this.notifyIcon1_DoubleClick);
            // 
            // process1
            // 
            this.process1.StartInfo.Domain = "";
            this.process1.StartInfo.FileName = "C:\\Users\\mike\\source\\repos\\TestWindowsService\\TestWindowsService\\bin\\Debug\\TestWi" +
    "ndowsService.exe";
            this.process1.StartInfo.LoadUserProfile = false;
            this.process1.StartInfo.Password = null;
            this.process1.StartInfo.StandardErrorEncoding = null;
            this.process1.StartInfo.StandardOutputEncoding = null;
            this.process1.StartInfo.UserName = "";
            this.process1.StartInfo.WorkingDirectory = "C:\\Users\\mike\\source\\repos\\TestWindowsService\\TestWindowsService\\bin\\Debug";
            this.process1.SynchronizingObject = this;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(664, 555);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "Close";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabCenter
            // 
            this.tabCenter.Controls.Add(this.tabWords);
            this.tabCenter.Controls.Add(this.tabPadel);
            this.tabCenter.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabCenter.Location = new System.Drawing.Point(12, 12);
            this.tabCenter.Name = "tabCenter";
            this.tabCenter.SelectedIndex = 0;
            this.tabCenter.Size = new System.Drawing.Size(727, 537);
            this.tabCenter.TabIndex = 1;
            // 
            // tabWords
            // 
            this.tabWords.Controls.Add(this.txtOutputWords);
            this.tabWords.Controls.Add(this.txtInputWords);
            this.tabWords.Location = new System.Drawing.Point(4, 28);
            this.tabWords.Name = "tabWords";
            this.tabWords.Padding = new System.Windows.Forms.Padding(3);
            this.tabWords.Size = new System.Drawing.Size(719, 505);
            this.tabWords.TabIndex = 0;
            this.tabWords.Text = "Sorted Strophe";
            this.tabWords.UseVisualStyleBackColor = true;
            // 
            // txtOutputWords
            // 
            this.txtOutputWords.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtOutputWords.Location = new System.Drawing.Point(3, 250);
            this.txtOutputWords.Multiline = true;
            this.txtOutputWords.Name = "txtOutputWords";
            this.txtOutputWords.ReadOnly = true;
            this.txtOutputWords.Size = new System.Drawing.Size(713, 252);
            this.txtOutputWords.TabIndex = 1;
            // 
            // txtInputWords
            // 
            this.txtInputWords.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtInputWords.Location = new System.Drawing.Point(3, 3);
            this.txtInputWords.Multiline = true;
            this.txtInputWords.Name = "txtInputWords";
            this.txtInputWords.Size = new System.Drawing.Size(713, 241);
            this.txtInputWords.TabIndex = 0;
            this.txtInputWords.TextChanged += new System.EventHandler(this.txtInputWords_TextChanged);
            // 
            // tabPadel
            // 
            this.tabPadel.Controls.Add(this.txtOutputPadel);
            this.tabPadel.Controls.Add(this.txtInputPadel);
            this.tabPadel.Location = new System.Drawing.Point(4, 28);
            this.tabPadel.Name = "tabPadel";
            this.tabPadel.Padding = new System.Windows.Forms.Padding(3);
            this.tabPadel.Size = new System.Drawing.Size(719, 505);
            this.tabPadel.TabIndex = 1;
            this.tabPadel.Text = "Padel League";
            this.tabPadel.UseVisualStyleBackColor = true;
            // 
            // txtOutputPadel
            // 
            this.txtOutputPadel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtOutputPadel.Location = new System.Drawing.Point(3, 250);
            this.txtOutputPadel.Multiline = true;
            this.txtOutputPadel.Name = "txtOutputPadel";
            this.txtOutputPadel.Size = new System.Drawing.Size(713, 252);
            this.txtOutputPadel.TabIndex = 1;
            // 
            // txtInputPadel
            // 
            this.txtInputPadel.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtInputPadel.Location = new System.Drawing.Point(3, 3);
            this.txtInputPadel.Multiline = true;
            this.txtInputPadel.Name = "txtInputPadel";
            this.txtInputPadel.Size = new System.Drawing.Size(713, 241);
            this.txtInputPadel.TabIndex = 0;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 590);
            this.Controls.Add(this.tabCenter);
            this.Controls.Add(this.btnExit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMain";
            this.Opacity = 0D;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMain";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabCenter.ResumeLayout(false);
            this.tabWords.ResumeLayout(false);
            this.tabWords.PerformLayout();
            this.tabPadel.ResumeLayout(false);
            this.tabPadel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NotifyIcon notifyIconTray;
        private System.Diagnostics.Process process1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TabControl tabCenter;
        private System.Windows.Forms.TabPage tabWords;
        private System.Windows.Forms.TextBox txtOutputWords;
        private System.Windows.Forms.TextBox txtInputWords;
        private System.Windows.Forms.TabPage tabPadel;
        private System.Windows.Forms.TextBox txtOutputPadel;
        private System.Windows.Forms.TextBox txtInputPadel;
    }
}

