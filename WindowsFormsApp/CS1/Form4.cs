using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS1
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();

            DataBase product = new Products();
            DataBase orders = new Orders();

            List<DataBase> databases = new List<DataBase>();
            databases.Add(product);
            databases.Add(orders);

            foreach(var val in databases)
            {
                val.Save();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Exceptions e1= new Exceptions();
            e1.GetData(10);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                Exceptions e1 = new Exceptions();
                e1.GetData(10);
            }
            catch(ArgumentOutOfRangeException ex)
            {
                this.Text = "インデックスのエラー";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                Exceptions e1 = new Exceptions();
                e1.GetData2(10);
            }
            catch (MyException ex)
            {
                this.Text =ex.Message;
                Console.WriteLine(ex.InnerException.Message);
            }
        }
    }
}
