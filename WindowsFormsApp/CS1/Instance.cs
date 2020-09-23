using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS1
{
    class Instance
    {
        private int _count = 0;

        public Instance(int count)
        {
            _count = count;
        }
        public void Call()
        {
            _count++;
        }
        public int GetCount()
        {
            return _count;
        }
    }
}
