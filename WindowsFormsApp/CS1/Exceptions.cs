using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS1
{
    public class Exceptions
    {
        private List<int> _values = new List<int>();

        public int GetData(int index)
        {
            return _values[index];
        }

        public int GetData2(int index)
        {
            try
            {
                return _values[index];
            }
            catch(ArgumentOutOfRangeException ex)
            {
                throw new MyException("マイエクセプション",ex);
            }
        }
    }
}
