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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            var capsel = new Capsel(0);
           // capsel._count = 100000; カプセル化されたので、他のクラスからは触れない
            capsel.Call();

            using (Database data = new Database())
            {
                //処理
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var instance = new Instance(10);
            instance.Call();
            instance.Call();
            instance.Call();
            MessageBox.Show(instance.GetCount().ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var instance = new Instance(3);
            instance.Call();
            instance.Call();
            MessageBox.Show(instance.GetCount().ToString());

            var instance2 = new Instance(8);
            instance2.Call();
            MessageBox.Show(instance2.GetCount().ToString());
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
