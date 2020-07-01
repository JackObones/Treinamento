using System;
using System.Globalization;
using Fixacao.Entities;
using System.Collections.Generic;
using System.Text;

namespace Fixacao.Entities
{
    class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public Product() { }

        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public virtual string PriceTag()
        {
            return Name
                + "$"
                + Price.ToString("F2", CultureInfo.InvariantCulture);
        }



    }
    
}
