namespace AssetTracking
{
    internal class MobilePhone : Asset
    {
        public MobilePhone(string type, string brand, string model, DateTime purchaseDate, int price)
        {
            Type = type;
            Brand = brand;
            Model = model;
            PurchaseDate = purchaseDate;
            Price = price;
        }

        public override void Print()
        {
            Console.ForegroundColor = IsEndOfLifeNear() ? ConsoleColor.Red : ConsoleColor.Gray;
            Console.WriteLine(Type.PadRight(20) + Brand.PadRight(20) + Model.PadRight(20) + PurchaseDate.ToString("yy/MM/dd").PadRight(20) + Price);
            Console.ResetColor();
        }

        public override bool IsEndOfLifeNear()
        {
            DateTime endOfLifeDate = PurchaseDate.AddYears(3);
            return endOfLifeDate < DateTime.Now.AddMonths(3);
        }
    }
}
