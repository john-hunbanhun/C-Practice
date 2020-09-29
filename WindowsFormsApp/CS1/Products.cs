using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS1
{
    class Products : IDatabase //インターフェースの実装
    {
        public void Save()
        {
            Console.WriteLine("商品マスタの登録");
        }
    }
}
