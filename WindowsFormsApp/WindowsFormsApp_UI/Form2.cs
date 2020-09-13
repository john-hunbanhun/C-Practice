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
    }
    }
    
