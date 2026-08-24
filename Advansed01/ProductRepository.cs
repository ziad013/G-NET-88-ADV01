using System;
using System.Collections.Generic;
using System.Text;

namespace Advansed01
{
    internal class ProductRepository : IRepository<Product>
    {
        List<Product> products = new List<Product>();
        public void Add(Product item)
        {
           products.Add(item);
        }

        public void Delete(int id)
        {
            products.Remove(products.Find(p => p.Id == id)!);
        }

        public Product Get(int id)
        {
            return products.Find(p => p.Id == id)!;
        }
    }
}
