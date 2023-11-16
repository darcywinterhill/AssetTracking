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
            if (IsEndOfLifeNear())
            {
                Console.ForegroundColor = ConsoleColor.Red;
            }
            else if (IsEndOfLifeAlmostNear())
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
            }

            Console.WriteLine(Type.PadRight(20) + Brand.PadRight(20) + Model.PadRight(20) + PurchaseDate.ToString("yy/MM/dd").PadRight(20) + Price);
            Console.ResetColor();
        }

        public override bool IsEndOfLifeNear()
        {
            DateTime endOfLifeDate = PurchaseDate.AddYears(3);
            return endOfLifeDate < DateTime.Now.AddMonths(3);
        }
        public override bool IsEndOfLifeAlmostNear()
        {
            DateTime endOfLifeDate = PurchaseDate.AddYears(3);
            return endOfLifeDate < DateTime.Now.AddMonths(6);
        }
    }
}
