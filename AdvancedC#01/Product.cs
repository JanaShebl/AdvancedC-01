using System;
using System.Collections.Generic;
using System.Text;

namespace AdvancedC_01
{
    internal class Product<T> where T:Item,IRepository<T>,new()
    {
        List<T> list = new List<T>();
        public void Add(T item)
        {
            list.Add(item);
        }
        public T Get(int id) { 
            return list[id];
        }

        public T Create(){ return new T(); }
    }
}
