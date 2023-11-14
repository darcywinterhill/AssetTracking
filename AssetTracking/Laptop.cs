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
