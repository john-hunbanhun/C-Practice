using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS1
{
    public class Database : IDisposable
    {
        private SqlDataAdapter _adapter = new SqlDataAdapter();
        public Database()
        {

        }

        public void Insert()
        {
            //書き方①
            //SqlConnection connection = new SqlConnection();
            //try
            //{
            //    //処理
            //}catch(Exception e)
            //{

            //}
            //finally //finallyで必ず通るようにする
            //{
            //    connection.Dispose();
            //}

            //書き方②　usingを使用したバージョン
            //usingは複数書くことが可能/Disposeを明示的に書く必要がない
            using (SqlConnection connection = new SqlConnection())
                using(SqlCommand command = new SqlCommand("select * from XXX",connection))
            {
                //処理
            }
        }
        public void Cancel()
        {
            _adapter.SelectCommand.Cancel();
        }

        public void Dispose()
        {
            if (_adapter != null)
            {
                _adapter.Dispose();
            }
        }
    }
}
