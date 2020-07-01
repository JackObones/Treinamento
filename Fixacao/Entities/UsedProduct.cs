using System;
using System.Globalization;
using System.Collections.Generic;
using System.Text;

namespace Fixacao.Entities
{
    class UsedProduct : Product
    {
        public DateTime ManufacturedDate { get; set; }

        public UsedProduct() { }

        public UsedProduct(string name, double price, DateTime manufacturedDate) 
            : base(name , price)
            
        {
            ManufacturedDate = manufacturedDate;
        }
        public override string ToString()
        {
            return Name
                + "(used) $"
                + Price.ToString("F2", CultureInfo.InvariantCulture)
                + "(Manufacrured date:"
                + ManufacturedDate.ToString("dd/MM/yyyy")
                + ")";
        }

    }
}

