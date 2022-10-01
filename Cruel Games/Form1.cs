using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cruel_Games
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            //
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (rbnLess21.Checked)
            {
                MessageBox.Show("You are too young!");
                Application.Exit();
            }
            else if (rbn21to35.Checked)
            {
                MessageBox.Show("Let's rock!!!");
            }
            else //(rbnMore35.Checked)
            {
                MessageBox.Show("You are too old, grandpa!");
                Application.Exit();
            }

        }
    }
}
