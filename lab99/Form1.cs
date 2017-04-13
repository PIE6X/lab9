using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab99
{
    public partial class Form1 : Form
    {
        Ukazat aaa = new Ukazat();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<int> pages = new List<int>(Array.ConvertAll(textBox2.Text.Split(' '), int.Parse));
            aaa.Add(textBox1.Text, pages);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
            ToTextBox();
        }
        public void ToTextBox()
        {
            richTextBox1.Text += aaa.Show() ;
           // richTextBox1.Text += "\n";
        }
        
    }
}
