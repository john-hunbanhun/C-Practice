using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp_UI
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();

            int i = 0;
            i += 2;
            i -= 1;

            i++;
            i--;

            int a = 10 % 4;
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int value = Convert.ToInt32(textBox1.Text);
            if(value ==10)
            {
                MessageBox.Show("10ですな");
            }
            else if (value == 20)
            {
                MessageBox.Show("20ですよ");
            }
            else
            {
                MessageBox.Show("10でも20でもないよ");
            }

            switch (value)
            {
                case 10:
                    MessageBox.Show("10やん");
                    break;
                case 20:
                    MessageBox.Show("20やろがい");
                    break;
                default:
                    MessageBox.Show("何でもないのう");
                    break;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int i = 0;

            while (i < 10)
            {
                i++;

                if (i == 3)
                {
                    continue;
                }
                if (i == 6)
                {
                    break;
                }
                MessageBox.Show(i.ToString());
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int i = 100;

            do
            {
                i++;
            } while (i <10);

            MessageBox.Show(i.ToString());
        }
    }
}
