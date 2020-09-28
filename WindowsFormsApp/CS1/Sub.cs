using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS1
{
    //書き方
    //多重継承禁止
    //子：サブクラス(派生クラス)
    class Sub:Super
    {
        public Sub(int value):base(value)
        {
            //派生クラスからはbaseキーワードで基底クラスの機能を使う
            base.ProtectedValue = 3;
        }
    }
}
