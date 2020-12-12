using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 加法
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {           
            if (textBox1 .Text == "" || textBox2.Text == "")
            {
                richTextBox1.Text = "尚未輸入";            
            }                       
            else
            {
                int a,b,z;
                a = int.Parse(textBox1.Text);
                b = int.Parse(textBox2.Text);
                z = a + b;
                richTextBox1.Text = z.ToString ();                
            }            
        }
    }
}
