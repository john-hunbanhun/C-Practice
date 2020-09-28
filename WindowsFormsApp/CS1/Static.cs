using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS1
{
    internal class Static
    {
        //静的メンバー
        //クラス、変数などにstaticキーワードを付ける
        //インスタンス単位でなく、クラス単位で生成される
        //つまり、アプリケーションにただ1つ
        private static int _count = 0;
        private int _value = 0;

        //静的メソッド
        internal static void Call()
        {
            //処理の中で使えるのは静的メンバーのみ
            _count++;
           
        }

        internal static int GetCount()
        {
            return _count;
        }
    }
}
