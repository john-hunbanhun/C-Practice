using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS1
{
    class Products : DataBase //インターフェースの実装
    {
        protected override void SaveMethod()
        {
            Console.WriteLine("商品マスタの登録");
        }
    }
}
