using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS1
{
    interface IDatabase //インターフェースは、頭に[I]を付けるのが慣例
    {
        void Save();
    }
}
