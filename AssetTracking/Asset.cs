using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace AssetTracking
{
    internal class Asset
    {
 
        public string Brand { get; set; }
        public string Model { get; set; }
        public DateTime PurchaseDate {  get; set; }
        public int Price { get; set; }

        public virtual string Print()
        {
            return Brand + Model + PurchaseDate + Price;
        }
    }

}
