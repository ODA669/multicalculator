using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_test
{
    public partial class moneyExchange : Form
    {
        public moneyExchange()
        {
            InitializeComponent();
            cad.Checked = true;
            cad2.Checked = true;
            usd.Checked = true;
            usd2.Checked = true;
            eur.Checked = true;
            eur2.Checked = true;
            gbp.Checked = true;
            gbp2.Checked = true;
            cop.Checked = true;
            cop2.Checked = true;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // strat conversion cad///////////////////////////////////////////
            if (cad.Checked && cad2.Checked)
            {
                double a = System.Convert.ToDouble(textBox1.Text);
                a = a * 1;
                textBox2.Text = System.Convert.ToString(a);
            }
            else
             if (cad.Checked && usd2.Checked)
            {
                double a = System.Convert.ToDouble(textBox1.Text);
                a = a * 0.80;
                textBox2.Text = System.Convert.ToString(a);
            }
            else
            if (cad.Checked && eur2.Checked)

            {

                double a = System.Convert.ToDouble(textBox1.Text);
                a = a * 0.72;
                textBox2.Text = System.Convert.ToString(a);
            }
            else
            if (cad.Checked && gbp2.Checked)

            {
                double a = System.Convert.ToDouble(textBox1.Text);
                a = a * 0.72;
                textBox2.Text = System.Convert.ToString(a);
            }
            else
            if (cad.Checked && cop2.Checked)

            {
                double a = System.Convert.ToDouble(textBox1.Text);
                a = a * 30005.38;
                textBox2.Text = System.Convert.ToString(a);
            }
            // end conversion cad/////////////////////////////////////////////////


            //start conversion usd//////////////////////////////////////////////////////////////
            
            if (usd.Checked && cad2.Checked)
            {
                double a = System.Convert.ToDouble(textBox1.Text);
                a = a * 1.25;
                textBox2.Text = System.Convert.ToString(a);
            }
            else
            if (usd.Checked && usd2.Checked)
            {
                double a = System.Convert.ToDouble(textBox1.Text);
                a = a * 1;
                textBox2.Text = System.Convert.ToString(a);
            }
            else
            if (usd.Checked && eur2.Checked)
            {
                double a = System.Convert.ToDouble(textBox1.Text);
                a = a * 0.90;
                textBox2.Text = System.Convert.ToString(a);
            }
            else
            if (usd.Checked && gbp2.Checked)
            {
                double a = System.Convert.ToDouble(textBox1.Text);
                a = a * 0.76;
                textBox2.Text = System.Convert.ToString(a);
            }
            else
            if (usd.Checked && cop2.Checked)
            {
                double a = System.Convert.ToDouble(textBox1.Text);
                a = a * 3751.14;
                textBox2.Text = System.Convert.ToString(a);
            }
            // end conversion usd//////////////////////////////////////////////////////////////////

            if (eur.Checked && cad2.Checked)
            {
                double a = System.Convert.ToDouble(textBox1.Text);
                a = a * 1.39;
                textBox2.Text = System.Convert.ToString(a);
            }
            else
            if (eur.Checked && eur.Checked)
            {
                double a = System.Convert.ToDouble(textBox1.Text);
                a = a * 1;
                textBox2.Text = System.Convert.ToString(a);
            }
            else
            if (eur.Checked && usd2.Checked)
            {
                double a = System.Convert.ToDouble(textBox1.Text);
                a = a * 1.12;
                textBox2.Text = System.Convert.ToString(a);
            }
            else
            if (eur.Checked && gbp2.Checked)
            {
                double a = System.Convert.ToDouble(textBox1.Text);
                a = a * 0.85;
                textBox2.Text = System.Convert.ToString(a);
            }
            else
            if (eur.Checked && cop2.Checked)
            {
                double a = System.Convert.ToDouble(textBox1.Text);
                a = a * 4186.46;
                textBox2.Text = System.Convert.ToString(a);
            }
            // end conversion eur
            //start conversion gbp
            if (gbp.Checked && cad2.Checked)
            {
                double a = System.Convert.ToDouble(textBox1.Text);
                a = a * 1.64;
                textBox2.Text = System.Convert.ToString(a);
            }
            else
            if (gbp.Checked && gbp2.Checked)
            {
                double a = System.Convert.ToDouble(textBox1.Text);
                a = a * 1;
                textBox2.Text = System.Convert.ToString(a);
            }
            else
            if (gbp.Checked && usd2.Checked)
            {
                double a = System.Convert.ToDouble(textBox1.Text);
                a = a * 1.31;
                textBox2.Text = System.Convert.ToString(a);
            }
            else
            if (gbp.Checked && eur2.Checked)

            {
                double a = System.Convert.ToDouble(textBox1.Text);
                a = a * 0.18;
                textBox2.Text = System.Convert.ToString(a);
            }
            else
            if (gbp.Checked && cop2.Checked)
            {
                double a = System.Convert.ToDouble(textBox1.Text);
                a = a * 4928.29;
                textBox2.Text = System.Convert.ToString(a);
            }
            // end conversion gbp
            //start conversion cop
            if (cop.Checked && cad2.Checked)
            {
                double a = System.Convert.ToDouble(textBox1.Text);
                a = a * 0.00033;
                textBox2.Text = System.Convert.ToString(a);

            }
            if (cop.Checked && cop2.Checked)
            {
                double a = System.Convert.ToDouble(textBox1.Text);
                a = a * 1;
                textBox2.Text = System.Convert.ToString(a);

            }
            else
           if (cop.Checked && usd2.Checked)
            {
                double a = System.Convert.ToDouble(textBox1.Text);
                a = a * 0.00027;
                textBox2.Text = System.Convert.ToString(a);
            }
            else
            if (cop.Checked && eur2.Checked)

            {
                double a = System.Convert.ToDouble(textBox1.Text);
                a = a * 0.00024;
                textBox2.Text = System.Convert.ToString(a);
            }
            else
            if (cop.Checked && gbp2.Checked)

            {
                double a = System.Convert.ToDouble(textBox1.Text);
                a = a * 0.00020;
                textBox2.Text = System.Convert.ToString(a);
            }
          
            // end conversion ccop
        }

        private void ext_Click(object sender, EventArgs e)
        {
            var res = MessageBox.Show("You are shure to want quit", "continue", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                this.Close();
            }
            else if (res == DialogResult.No)
            {
            }
        }

        private async void rdfile_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "tex document|*.txt", ValidateNames = true })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    using (StreamWriter sw = new StreamWriter(sfd.FileName))
                    {
                        await sw.WriteLineAsync(textBox1.Text);
                        MessageBox.Show(" you have been succesfully saved.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                }
            }
        }

        private void moneyExchange_Load(object sender, EventArgs e)
        {

        }
    }
}
