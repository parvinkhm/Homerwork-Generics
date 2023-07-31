using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repeat
{
    internal class StringList
    {
        private string[] _stringlist;
        
        public StringList()
        {
            _stringlist = Array.Empty<string>();
        }

        public void Add(string str)
        {
            Array.Resize(ref _stringlist, _stringlist.Length + 1);
            _stringlist[_stringlist.Length - 1] = str;
        }

        public string[] GetAll()
        {
            return _stringlist;
        }
    }
}
