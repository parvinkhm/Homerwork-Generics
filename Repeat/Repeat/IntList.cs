using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repeat
{
    internal class IntList
    {
        private int[] _intlist;

        public IntList()
        {
            _intlist = new int[0];
        }

        public void Add(int num)
        {
            Array.Resize(ref _intlist, _intlist.Length + 1);
            _intlist[_intlist.Length -1] = num;
        }

        public int[] GetAll()
        {
            return _intlist; 
        }
    }
}
