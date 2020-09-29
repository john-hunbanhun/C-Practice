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
    }
}
