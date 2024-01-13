using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exercicios_6.Entities
{
    public class ImportedProduct : Product
    {
        public double CustomFee { get; set; }


        public ImportedProduct()
        {

        }

        public ImportedProduct(string name, double price, double customFee) : base(name, price)
        {
            Name = name;
            Price = price;
            CustomFee = customFee;
        }


        public override string PriceTag()
        {
            return $"{Name} {Price:C} (Customs fee: {CustomFee:C})";
        }

        public double TotalPrice()
        {
            return Price + CustomFee;
        }
    }
}