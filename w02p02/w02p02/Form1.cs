using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace w02p02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            richTextBox1.AppendText("Zdarzenie ACTIVATE\n");
            richTextBox1.BackColor = SystemColors.Window;
        }

        private void Form1_Deactivate(object sender, EventArgs e)
        {
            richTextBox1.AppendText("Zdarzenie DEACTIVATE\n");
            richTextBox1.BackColor = Color.Gray;
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            richTextBox1.AppendText("Zdarzenie SHOWN\n");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            richTextBox1.AppendText("Zdarzenie LOAD\n");
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Czy jesteś pewien?","Pytanie",MessageBoxButtons.YesNo,MessageBoxIcon.Question) 
                == DialogResult.No) { e.Cancel = true; }
        }

        private void Form1_Click(object sender, EventArgs e)
        {
         /*   richTextBox1.AppendText("Kliknięto\n");*/
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                richTextBox1.AppendText("Kliknięto LB\n");
            else if (e.Button == MouseButtons.Right)
                richTextBox1.AppendText("Kliknięto RB\n");
            else if (e.Button == MouseButtons.Middle)
                richTextBox1.AppendText("Kliknięto MB\n");
            richTextBox1.AppendText("x:" + e.Location.X.ToString() + " y:" + e.Location.Y.ToString()+"\n");
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            label2.Text = e.Location.X.ToString()+" "+e.Location.Y.ToString();
            label2.ForeColor = Color.Black;
        }

        private void richTextBox1_MouseMove(object sender, MouseEventArgs e)
        {
            label2.Text = e.Location.X.ToString() + " " + e.Location.Y.ToString();
            label2.ForeColor = Color.Red;
        }

        private void richTextBox1_MouseLeave(object sender, EventArgs e)
        {
            richTextBox1.Visible = true;
        }

        private void richTextBox1_MouseEnter(object sender, EventArgs e)
        {
            richTextBox1.Visible = false;
        }
    }
}
