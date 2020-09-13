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
            byte byteValue = 255;
            // byte byteValue2 = 256;

            short shortValue = 10;
            short shortMax = short.MaxValue;
            short shortMin = short.MinValue;

            int intValue = 23;
            int intMax = int.MaxValue;

            long longValue = 10;

            float floatValue = 1.23f;
            double doubleValue = 1.23d;
            decimal decimalValue = 1.23m;

            bool boolValue = true;
            if (boolValue)
            {
                //true
            }
            else if (!boolValue)
            {
                //false
            }

            string stringValue = "abcd";
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
