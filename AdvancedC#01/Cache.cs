using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace AdvancedC_01
{
    // expiration support.
    internal class Cache<TKey, TValue>
    {
        Dictionary<TKey, TValue> _list=new Dictionary<TKey, TValue>();
        public void Add(TKey key, TValue value) {
            if (!_list.ContainsKey(key))
            {
                _list[key] = value;
                DateTime a= DateTime.Now;
            }
            else
            {
                throw new Exception("Invalid");
            }
        }

        public TValue Get(TKey key)
        {
            if(_list.ContainsKey(key))
            {
                return _list[key];
            }
            else
            {
                throw new KeyNotFoundException("Invalid");
            }
        }

        public bool Remove(TKey key) { 
            return _list.Remove(key);
        }

        public bool Contains(TKey key)
        {
            return (_list.ContainsKey(key));
        }

    }
    //public class calc
    //{

    //} // مش عارفة اعمل ال expiration
}
