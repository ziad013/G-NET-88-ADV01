using System;
using System.Collections.Generic;
using System.Text;

namespace Advansed01
{
    internal class Container<T>
    {
        public T value { get; set; }

        public void Add(T val)
        {
            value = val;
        }

        public T get()
        {
            return value;
        }
    }
}
