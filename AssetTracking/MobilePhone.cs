namespace AssetTracking
{
    internal class MobilePhone : Asset
    {
        public MobilePhone() { }
        public MobilePhone(string type, string brand, string model, DateTime purchaseDate, int price)
        {
            Type = type;
            Brand = brand;
            Model = model;
            PurchaseDate = purchaseDate;
            Price = price;
        }

        //Method to display message when product is added
        public override void AddedMessage()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Produkten lades till");
            Console.ResetColor();
        }

        //Display list - different color on assets depending on End of Life
        public override void Print()
        {
            if (IsEndOfLifeNear())
            {
                Console.ForegroundColor = ConsoleColor.Red;
            }
            else if (IsEndOfLifeAlmostNear())
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
            }

            Console.WriteLine(Type.PadRight(20) + Brand.PadRight(20) + Model.PadRight(20) +
                                PurchaseDate.ToString("yy/MM/dd").PadRight(20) + Price);
            Console.ResetColor();
        }

        //True if End of Life is closer than 3 months (or overdue)
        public override bool IsEndOfLifeNear()
        {
            DateTime endOfLifeDate = PurchaseDate.AddYears(3);
            return endOfLifeDate < DateTime.Now.AddMonths(3);
        }

        //True if End of Life is closer than 6 months
        public override bool IsEndOfLifeAlmostNear()
        {
            DateTime endOfLifeDate = PurchaseDate.AddYears(3);
            return endOfLifeDate < DateTime.Now.AddMonths(6);
        }
    }
}
