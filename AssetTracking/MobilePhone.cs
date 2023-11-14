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

    }
}
