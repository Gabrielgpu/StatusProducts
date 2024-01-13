using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exercicios_6.Entities
{
    public class UsedProduct : Product
    {
        public DateTime ManufactureDate { get; set; }


        public UsedProduct()
        {

        }

        public UsedProduct(string name, double price, DateTime manufactureDate) : base(name, price)
        {
            Name = name;
            Price = price;
            ManufactureDate = manufactureDate;
        }


        public override string PriceTag()
        {
            return $"{Name} (used) {Price:C} (Manufacture date: {ManufactureDate})";
        }
    }
}