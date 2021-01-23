using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionary
{
    class MyDict<T>
    {
        T[] items;
        public MyDict()
        {
            items = new T[0];
        }

        public void Add(T item)
        {
            T[] tempArr = items;
            items = new T[items.Length + 1];
                for (int i = 0; i < tempArr.Length; i++)
            {
                items[i] = tempArr[i];
            }
            items[items.Length - 1] = item;
        }
    }
}
