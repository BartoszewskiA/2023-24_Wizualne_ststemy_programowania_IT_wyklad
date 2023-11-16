using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace w02p03
{
    public partial class Form1 : Form
    {
        int i = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
/*            if (e.KeyChar == 'q')
                i++;
            else if (e.KeyChar == 'a') i--;
            label1.Text = i.ToString();*/
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up) i++;
            else if (e.KeyCode == Keys.Down) i--;
            else if (e.KeyCode == Keys.Escape) i = 0;
            label1.Text = i.ToString();
        }
    }
}
