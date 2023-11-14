using AssetTracking;

Console.WriteLine("Här kan du se dina tillgångar!");
Console.WriteLine();

List<Asset> assets = new List<Asset>();

string date1string = "2012-11-23";
DateTime date1 = Convert.ToDateTime(date1string);

string date2string = "2012-11-23";
DateTime date2 = Convert.ToDateTime(date2string);

string date3string = "2012-11-23";
DateTime date3 = Convert.ToDateTime(date3string);

string date4string = "2012-11-23";
DateTime date4 = Convert.ToDateTime(date4string);

string date5string = "2012-11-23";
DateTime date5 = Convert.ToDateTime(date5string);

assets.Add(new Laptop("MacBook", "XX", date1, 345));
assets.Add(new Laptop("Asus", "WXY", date2, 458));
assets.Add(new Laptop("Lenovo", "ZED", date3, 452));
assets.Add(new MobilePhone("IPhone", "11", date4, 652));
assets.Add(new MobilePhone("Samsung", "10", date5, 365));

while (true)
{
    Console.Write("Ange märke: ");
    string brand = Console.ReadLine();

    if (brand == "exit")
    {
        break;
    }

    Console.Write("Ange modell: ");
    string model = Console.ReadLine();

    Console.Write("Ange inköpsdatum (YYYY/MM/DD: ");
    string dateInput = Console.ReadLine();
    DateTime purchaseDate = Convert.ToDateTime(dateInput);

    Console.Write("Ange pris: ");
    int price = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Är det en (1) laptop eller (2) mobiltelefon du vill lägga till?");
    string typeInput = Console.ReadLine();

    if (typeInput == "1")
    {
        assets.Add(new Laptop(brand, model, purchaseDate, price));
    }
    else if (typeInput == "2")
    {
        assets.Add(new MobilePhone(brand, model, purchaseDate, price));
    }
}

Console.WriteLine("Brand".PadRight(20) + "Model".PadRight(20) + "Purchase Date".PadRight(20) + "Price");
Console.WriteLine("--------------------------------------------------------------------------------");
foreach (Asset asset in assets)
{

    Console.WriteLine(asset.Print());
}



