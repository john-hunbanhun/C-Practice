using CS1_2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS1
{
    public class A1
    {
        public A1()
        {
            var a2 = new A2();
            var bp = new BP();
            //var bi = new BI();

            var a3 = new A3();
            a3.InternalMethod();
            a3.InternalProtectedMethod();
            a3.PublicMethod();

        }
    }

    internal class A11 : A3
    {
        public A11()
        {
            base.ProtectedMethod(); //継承先でアクセス修飾子Protectedを呼ぶには、baseというキーワードを使用する！
        }
    }
}
