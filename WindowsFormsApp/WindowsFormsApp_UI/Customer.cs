using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp_UI
{
    class Customer
    {
        /// <summary>
        /// 顧客クラス
        /// </summary>
        public string FirstName;
        public string LastName;

        /// <summary>
        /// C#のコンストラクタの書き方
        /// </summary>
        public Customer(string firstName,string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public Customer(string lastName):this("名の記入なし。　",lastName)
        {
            LastName += "様の";
        }

        public string GetFullName()
        {
            return LastName + FirstName;
        }
    }
}
