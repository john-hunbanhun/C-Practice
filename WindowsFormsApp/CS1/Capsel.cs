using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS1
{
   public class Capsel
    {
        private int _count = 0; //カプセル化している

        /// <summary>
        /// コンストラクタで初期値を投げてあげる
        /// </summary>
        /// <param name="count"></param>
        public Capsel(int count)
        {
            _count = count;
        }

        public void Call()
        {
            _count++;
        }

        /// <summary>
        /// メソッドで値を投げてあげる.外部からアクセスできるようにしておく
        /// </summary>
        /// <param name="value"></param>
        public void SetCount(int value)
        {
            if (value > 100)
            {
                _count = 0;
            }
            _count = value;
        }
        //外部から値を取得できるようにしておく
        public int GetCount()
        {
            return _count;
        }
    }
}
