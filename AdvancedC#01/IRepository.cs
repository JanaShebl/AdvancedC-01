using System;
using System.Collections.Generic;
using System.Text;

namespace AdvancedC_01
{
    internal interface IRepository<T>
    {
        void Add(T item);
        T Get(int id);
    }
}
