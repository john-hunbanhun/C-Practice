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

        public string GetFullName()
        {
            return LastName + FirstName;
        }
    }
}
