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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
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

            // sortedStrophe obj = new sortedStrophe();

            // obj.TextInput11 = textBox1.Text + Environment.NewLine;
            // textBox2.Text =  obj.recorrerArray(obj.TextInput11);

            //new Version of code
            Controller obj = new Controller();
            textBox2.Text = obj.readData(textBox1.Text + Environment.NewLine + Environment.NewLine);
            
            
        }
        

        public string invertircadena(string output)
        {
            this.textBox2.Text = output;
            return output;
        }

    }
}
