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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Customer customer1 = new Customer("谷澤");
            Customer customer2 = new Customer("ミラ","滝口");

            MessageBox.Show(customer1.GetFullName()+customer2.GetFullName());
        }
    }
}
