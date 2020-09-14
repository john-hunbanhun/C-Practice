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
    public partial class Form2 : Form
    {
        //変数
        private int _value = 0;

        //定数
        private const int Value = 2;
        private const string Key = "abcdefg";
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    
        private void button1_Click_1(object sender, EventArgs e)
        {
            _value = _value + 1;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show(_value.ToString());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int a = 10;
            int b = 20;

            MessageBox.Show("a=" + a+", b="+b);

            a = b;
            MessageBox.Show("a=" + a + ", b=" + b);

            b = 30;
            MessageBox.Show("a=" + a + ", b=" + b);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Other a = new Other();
            Other b = new Other();

            a.Value = 10;
            b.Value = 20;
            MessageBox.Show("a=" + a.Value + ", b=" + b.Value);

            a = b;
            MessageBox.Show("a=" + a.Value + ", b=" + b.Value);

            b.Value = 30;
            MessageBox.Show("a=" + a.Value + ", b=" + b.Value); //a=30? 上記a=bをしたため、aとbが同じ参照先になってしまった。
        }

        private void OtherMethod(Other other)
        {
            other.Value = 55;
        }
        private void intMethod(int value)
        {
            value = 60;
        }
        public class Other
        {
            public int Value;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Other a = new Other();
            a.Value = 10;
            MessageBox.Show("a=" + a.Value);

            OtherMethod(a);
            MessageBox.Show("a=" + a.Value);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int a = 15;
            MessageBox.Show("a=" + a);

            intMethod(a);
            MessageBox.Show("a=" + a);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            double d1 = 1.4d;
            int a = (int)d1;
            MessageBox.Show(a.ToString());

            short shortValue = 10;
            int intValue = shortValue;
            byte byteValue = (byte)shortValue;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            string value = "10";
            int intValue=Convert.ToInt32(value);
            MessageBox.Show(intValue.ToString());
        }
    }
    }
    
