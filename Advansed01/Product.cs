using System;
using System.Collections.Generic;
using System.Text;

namespace Advansed01
{
    internal class Product : IComparable<Product>
    {
        public Product()
        {
            
        }
        public string Name { get; set; }

        public int Id { get; set; }

        public decimal Price { get; set; }

        public Product(int id ,string name, decimal price)
        {
            Id = id;
            Name = name;
            Price = price;
        }

        public int CompareTo(Product? other)
        {
            if (Price > other?.Price)
                return 1;
            else if (Price < other?.Price)
                return -1;
            else 
                return 0;
        }
    }
}
