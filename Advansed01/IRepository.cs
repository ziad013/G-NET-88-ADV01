using System;
using System.Collections.Generic;
using System.Text;

namespace Advansed01
{
    internal interface IRepository<T>
    {
        void Add(T item);
        void Delete(int id);
        T Get(int id);
    }
}
