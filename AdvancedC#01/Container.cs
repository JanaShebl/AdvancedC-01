using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Channels;

namespace AdvancedC_01
{
    internal class Container<T>
    {
        private List<T> _list=new List<T>();
        public void Add(T item)
        {
            _list.Add(item);
        }
        public T Get(int idx)
        {
            if(idx<0 || idx >= _list.Count)
            {
                throw new IndexOutOfRangeException("invalid index"); 
            }
            return _list[idx];
        }
    }
}
