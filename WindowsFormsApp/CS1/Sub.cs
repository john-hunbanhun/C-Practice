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

        //オーバーライド
        //派生クラスで基底クラスのメソッドを書き換える
        //派生クラス：overrideキーワード
        //「書き換えますよ」の意味
        public override int GetData()
        {
            var value = base.GetData();
            value += 3;
            return value;
        }
    }
}
