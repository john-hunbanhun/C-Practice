using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS1
{
    class Orders : DataBase
    {
        protected override void SaveMethod()
        {
            Console.WriteLine("発注テーブル登録");
        }
    }
}
