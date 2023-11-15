namespace AssetTracking
{
    internal class Laptop : Asset
    {

        public Laptop(string type, string brand, string model, DateTime purchaseDate, int price)
        {
            Type = type;
            Brand = brand;
            Model = model;
            PurchaseDate = purchaseDate;
            Price = price;
        }
        public override void Print()
        {
            Console.WriteLine("Laptop".PadRight(20) + Brand.PadRight(20) + Model.PadRight(20) + PurchaseDate.ToString("yy/MM/dd").PadRight(20) + Price);
        }

    }
}
