using System;
using System.Collections.Generic;
using System.Text;

namespace Advansed01
{
    internal class Product
    {

        public string Name { get; set; }

        public int Id { get; set; }

        public decimal Price { get; set; }

        public Product(int id ,string name, decimal price)
        {
            Id = id;
            Name = name;
            Price = price;
        }
       
    }
}
