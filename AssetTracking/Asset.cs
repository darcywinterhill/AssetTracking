namespace AssetTracking
{
    internal class Asset
    {

        public string Brand { get; set; }
        public string Model { get; set; }
        public DateTime PurchaseDate { get; set; }
        public int Price { get; set; }

        public string Print()
        {
            return Brand.PadRight(20) + Model.PadRight(20) + PurchaseDate.ToString("yyyy/MM/dd").PadRight(20) + Price;
        }
    }

}
