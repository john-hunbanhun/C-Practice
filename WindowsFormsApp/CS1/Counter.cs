using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS1
{
   public class Counter
    {
        private int _count = 0; //カプセル化している

       
        public Counter(int count)
        {
            _count = count;
        }

        //プロパティの書き方
        public int Count
        {
            get
            {
                return _count;
            }
            set
            {
                if (value > 100)
                {
                    _count = 0;
                    return;
                }
                _count = value;
            }
        }

        public class Client
        {
            public Client()
            {
                var counter = new Counter(0);
                counter.Count = 1000;
                var sample = counter.Count;
            }
        }

        public void Call()
        {
            _count++;
        }

       
        public void SetCount(int value)
        {
            if (value > 100)
            {
                _count = 0;
            }
            _count = value;
        }
   
        public int GetCount()
        {
            return _count;
        }
    }
}
