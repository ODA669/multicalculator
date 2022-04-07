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
    public partial class lotto : Form
    {

        public lotto()
        {
            InitializeComponent();

        }

        
        private void button1_Click(object sender, EventArgs e)
        {

            Random random = new Random(unchecked((int)DateTime.Now.Ticks));

            int tmp;
            int[] arr = new int[7];

            string p = "";

            // MessageBox.Show(randonNumber.ToString());
            for (int i = 0; i < 7; i++)
            {

                tmp = random.Next(1, 49);
                arr[i] = getNum(arr, tmp, random);

                p += arr[i] + "\n";


            }
            textBox1.Text = p;


        }
        public int getNum(int[] arrnum, int tmp, Random random)
        {
            //bool check = false;
            int n = 0;
            while (n <= arrnum.Length - 1)
            {
                if (arrnum[n] == tmp)
                {
                    tmp = random.Next(1, 49);
                    getNum(arrnum, tmp, random);

                }

                n++;
            }
            return tmp;
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

        private async void button2_Click(object sender, EventArgs e)
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
        }//the end the button reading file
        
        private void lotto_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
