using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
         
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lottoMax lot = new lottoMax();
            lot.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            lotto lot2 = new lotto();
            lot2.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            calculator clc = new calculator();
            clc.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            moneyExchange mon = new moneyExchange();
            mon.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Convert conv = new Convert();
            conv.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            var res = MessageBox.Show("You are shure to want quit", "continue", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                Application.Exit();
            }
            else if (res == DialogResult.No)
            {
            }
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
