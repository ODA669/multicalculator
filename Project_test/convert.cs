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
    public partial class Convert : Form
    {
        public Convert()
        {
            InitializeComponent();
          
        }

        private void Convert_Load(object sender, EventArgs e)
        {
            celcius.Checked = true;
            Fahren.Checked = true;
        }



        private void Button1_Click(object sender, EventArgs e)
        {

            

            if (celcius.Checked && Fahren.Checked)
            {
                double a = System.Convert.ToDouble(textBox1.Text);
                a = (a * 9) / 5 + 32;
                textBox2.Text = System.Convert.ToString(a);

                

                if (a > 99)
                {
                    textBox3.Text = ("Water boils");
                }
                else if (a < 100 && a > 30)
                {
                    textBox3.Text = ("Hot Bath");

                }
                else if (a < 40 && a > 36)
                {
                    textBox3.Text = ("Body temperature");

                }
                else if (a < 37 && a > 29)
                {
                    textBox3.Text = ("Beach weather");
                }
                else if (a < 30 && a > 20)
                {
                    textBox3.Text = ("Room temperature");

                }
                else if (a < 21 && a > 9)
                {
                    textBox3.Text = ("Cool Day");
                }
                else if (a < 10 && a > (-1))
                {
                    textBox3.Text = ("Freezing Point of water");
                }
                else if (a < 0 && a > (-19))
                {
                    textBox3.Text = ("Very Cold Day");
                }
                else if (a < (-18) && a > (-39))s
                {
                    textBox3.Text = ("Extremely Cold Day"
                        + "\n(and the same number!WOW....)");
                }
                else
                {
                    textBox3.Text = ("Bold are exact");
                }
            }
           /* else
            {
                double a = System.Convert.ToDouble(textBox1.Text);
                a = (a - 32) * 5 / 9;
                textBox2.Text = System.Convert.ToString(a);
                

                if (b > 99)
                {
                    textBox3.Text = ("Water boils");
                }
                else if (a < 100 && a > 30)
                {
                    textBox3.Text = ("Hot Bath");

                }
                else if (a < 40 && a > 36)
                {
                    textBox3.Text = ("Body temperature");

                }
                else if (a < 37 && a > 29)
                {
                    textBox3.Text = ("Beach weather");
                }
                else if (a < 30 && a > 20)
                {
                    textBox3.Text = ("Room temperature");

                }
                else if (a < 21 && a > 9)
                {
                    textBox3.Text = ("Cool Day");
                }
                else if (a < 10 && a > (-1))
                {
                    textBox3.Text = ("Freezing Point of water");
                }
                else if (a < 0 && a > (-19))
                {
                    textBox3.Text = ("Very Cold Day");
                }
                else if (a < (-18) && a > (-39))
                {
                    textBox3.Text = ("Extremely Cold Day"
                        + "\n(and the same number!WOW....)");
                }
                else
                {
                    textBox3.Text = ("Bold are exact");
                }

            } */
            
        }
        private async void Button2_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "text document|*.txt", ValidateNames = true })
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
        private void button3_Click(object sender, EventArgs e)
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
        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }//the end the class of Convertemperature

}
