using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS1
{
    public class Field
    {
        private int _count = 0; //フィールド名は頭に_を付けるのが慣例(命名規約)

        public void Call()
        {
            int count = 0;

            _count++;
        }
    }
}
