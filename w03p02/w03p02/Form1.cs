using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace w03p02
{
    public partial class Form1 : Form
    {
        int l = 0;
        int maxInter;
        public Form1()
        {
            InitializeComponent();
            maxInter = timer1.Interval;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(progressBar1.Value < progressBar1.Maximum)
                progressBar1.Value++;
            else timer1.Stop();
    label1.Text = timer1.Interval.ToString()+ " "+(l++).ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(progressBar1.Value == progressBar1.Maximum) progressBar1.Value = 0;
            timer1.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            
        }

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            timer1.Interval = maxInter - trackBar1.Value * 50;
        }
    }
}
