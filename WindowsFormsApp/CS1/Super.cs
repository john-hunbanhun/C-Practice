using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS1
{
    //親：スーパークラス(基底クラス)
    class Super
    {
        private int _privateValue;
        protected int ProtectedValue;

        //コンストラクタ
        public Super(int value)
        {
            _privateValue = value;
        }

        public int GetData()
        {
            return 1;
        }
    }
}
