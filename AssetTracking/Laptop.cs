using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssetTracking
{
    internal class Laptop : Asset
    {
        public Laptop(string brand, string model, DateTime purchaseDate, int price)
        {
            Brand = brand;
            Model = model;
            PurchaseDate = purchaseDate;
            Price = price;
        }

    }
}
