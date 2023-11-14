using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssetTracking
{
    internal class MobilePhone : Asset
    {
        public MobilePhone(string brand, string model, DateTime purchaseDate, int price)
        {
            Brand = brand;
            Model = model;
            PurchaseDate = purchaseDate;
            Price = price;
        }

        public override string Print()
        {
            return Brand.PadRight(20) + Model.PadRight(20) + PurchaseDate.ToString("yyyy/MM/dd").PadRight(20) + Price;
        }
    }
}
