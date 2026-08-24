using System;
using System.Collections.Generic;
using System.Text;

namespace Advansed01
{
    public class Repository<T> where T : class, IComparable<T>, new()
    {
        public T Create()
        {
            return new T();
        }
    }
}
