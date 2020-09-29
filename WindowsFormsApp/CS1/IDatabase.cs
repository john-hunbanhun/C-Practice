using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS1
{
    //インターフェースは、頭に[I]を付けるのが慣例
    public abstract class DataBase 
    {
        public void Save() {
            try
            {
                Transaction();

                //save処理
                SaveMethod();

                Commit();
            }
            catch
            {
                RollBack();
            }
        }

        protected abstract void SaveMethod();
        
        private void Transaction()
        {

        }
        private void Commit()
        {

        }
        private void RollBack()
        {

        }
    }
}
