using System;
using System.Collections.Generic;
using System.Text;

namespace AdvancedC_01
{
    internal class SafeList<T>
    {
        List<T> list = new List<T>();
        public void Add(T item)
        {
            list.Add(item);
        }
        public T Get(int idx)
        {
            if (idx < 0 || idx >= list.Count)
            {
                return default(T);
            }
            return list[idx];
        }
    }
}
