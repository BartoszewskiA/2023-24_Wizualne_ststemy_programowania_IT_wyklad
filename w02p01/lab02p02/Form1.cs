using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab02p02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String s1 = textBox1.Text;
            String s2 = textBox2.Text;
            int d1,d2;
            if (!int.TryParse(s1, out d1)) 
            {
                d1 = 0;
                textBox1.Text = d1.ToString();
            }
            if(!int.TryParse(s2, out d2))
            {
                d2 = 0;
                textBox2.Text = d2.ToString();
            }

            textBox3.Text = (d1+d2).ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Clear();
            textBox3.Clear();

        }
    }
}
