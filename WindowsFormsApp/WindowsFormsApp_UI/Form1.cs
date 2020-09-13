using System.Windows.Forms;


/// <summary>
/// 名前空間
/// </summary>
namespace WindowsFormsApp_UI
{
    /// <summary>
    /// クラス
    /// </summary>
    public partial class Form1 : Form
    {
        private int _value = 0;
        public Form1()
        {
            InitializeComponent();

            _value = 2;
           
        }

        private int GetValue()
        {
            int valueM = 0;
            _value = 3;
            valueM = 5;
            return 1;
        }

        private void SetValue()
        {
            MessageBox.Show("Hello World!");
        }
    }
}
