using System;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            //this.ShowInTaskbar = false;
            //this.Load += new EventHandler(Form1_Load);

            //this.Visible = false;
        }

        

       

        private void Form1_Load(object sender, EventArgs e)
        {
            notifyIcon1.ShowBalloonTip(1000, "Important notice", " Double click to display the form", ToolTipIcon.Info);
        }

        private void notifyIcon1_DoubleClick(object sender, EventArgs e)
        {
            this.Opacity = 100;
            this.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //this methods are for the version final 
            //this.Hide();
            //notifyIcon1.ShowBalloonTip(1000, "Important Notice", "Double click to display the form", ToolTipIcon.Info);

            string area= "";
            stanza obj = new stanza();
            obj.TextInput11 = textBox1.Text + Environment.NewLine;

            area =  obj.recorrerArray(obj.TextInput11);

            textBox2.Text = area;
            

            
        }
     

        public string invertircadena(string output)
        {
            this.textBox2.Text = output;
            return output;
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
           // this.Hide();
        }
    }
}
