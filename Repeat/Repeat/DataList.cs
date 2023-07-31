using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repeat
{
    internal class DataList<T> where T : BaseEntity
    {
        private T[] _datas;

        public DataList()
        {
            _datas = Array.Empty<T>();
        }

        public void Add(T item)
        {
            Array.Resize(ref _datas, _datas.Length + 1);
            _datas[_datas.Length - 1] = item;
        }

        public T[] GetAll()
        {
            return _datas;
        }

        public T GetById(int id)
        {
            foreach (var item in _datas)
            {
               if(item.Id == id)
                    return item;
            }

            return null;
        }
    }
}
