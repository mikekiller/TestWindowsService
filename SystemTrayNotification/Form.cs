using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SystemTrayNotification
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ShowNotificationBallon();
            
        }

        private void notifyIcon1_DoubleClick(object sender, EventArgs e)
        {
            this.Opacity = 100;
            this.Show();
        }
        private void ShowNotificationBallon()
        {
            notifyIconTray.ShowBalloonTip(1000, "Important notice", " Double click to display the form", ToolTipIcon.Info);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Opacity = 0;
            txtInputWords.Text = "";
            txtOutputWords.Text = "";
            ShowNotificationBallon();

        }


        private void txtInputWords_TextChanged(object sender, EventArgs e)
        {
            Controller obj = new Controller();
            txtOutputWords.Text = obj.ReadData(txtInputWords.Text + Environment.NewLine + Environment.NewLine);
        }
    }
}
