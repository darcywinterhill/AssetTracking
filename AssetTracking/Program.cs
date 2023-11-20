using AssetTracking;

List<Asset> assets = new List<Asset>();
Laptop l = new Laptop();
MobilePhone m = new MobilePhone();

Console.WriteLine("Här kan du hantera dina tillgångar!");
Console.WriteLine("För att avsluta och/eller se en lista över dina tillgångar, skriv 'exit'.");
Console.WriteLine();

// * ADD PRODUCT
while (true)
{
    Console.WriteLine("-------------------------------------------------");
    Console.WriteLine(" >>> LÄGG TILL PRODUKT <<<");
    Console.WriteLine();

    //Brand input
    Console.Write(" >> Ange märke: ");
    string brand = Console.ReadLine();

    bool isBrandEmpty = string.IsNullOrWhiteSpace(brand);

    if (brand.ToLower().Trim() == "exit")
    {
        break;
    }

    while (isBrandEmpty)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write("Ange märke: ");
        Console.ResetColor();
        brand = Console.ReadLine();
        isBrandEmpty = string.IsNullOrWhiteSpace(brand);
    }

    //Model input
    Console.Write(" >> Ange modell: ");
    string model = Console.ReadLine();

    bool isModelEmpty = string.IsNullOrWhiteSpace(model);

    if (model.ToLower().Trim() == "exit")
    {
        break;
    }

    while (isModelEmpty)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write("Ange modell: ");
        Console.ResetColor();
        model = Console.ReadLine();
        isModelEmpty = string.IsNullOrWhiteSpace(model);
    }

    //Purcahse date input
    Console.Write(" >> Ange inköpsdatum (YY/MM/DD: ");
    string dateInput = Console.ReadLine();

    DateTime purchaseDate;
    bool isDate = DateTime.TryParse(dateInput, out purchaseDate);

    if (dateInput.ToLower().Trim() == "exit")
    {
        break;
    }

    try //Try-catch if input is not DateTime type
    {
        purchaseDate = Convert.ToDateTime(dateInput);
    }
    catch (FormatException)
    {
        while (!isDate)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("Ange ett giltigt datum: ");
            Console.ResetColor();
            dateInput = Console.ReadLine();
            isDate = DateTime.TryParse(dateInput, out purchaseDate);
        }
    }

    //Price input
    Console.Write(" >> Ange pris: ");
    string priceInput = Console.ReadLine();

    bool isPriceInt = int.TryParse(priceInput, out int price);

    if (dateInput.ToLower().Trim() == "exit")
    {
        break;
    }

    try //Try-catch if input is not int type
    {
        price = Convert.ToInt32(priceInput);
    }
    catch (FormatException)
    {
        while (!isPriceInt)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("Ange ett pris (siffror, heltal): ");
            Console.ResetColor();
            priceInput = Console.ReadLine();
            isPriceInt = int.TryParse(priceInput, out price);
        }
    }

    //Type input
    Console.Write(" >> Är det en (1) laptop eller (2) mobiltelefon du vill lägga till? ");
    string typeInput = (Console.ReadLine());

    bool isTypeInt = int.TryParse(typeInput, out int intTypeInput);

    //Error handling for wrong type input
    while (!isTypeInt)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write("Ange en siffra - (1) för laptop och (2) för mobiltelefon: ");
        Console.ResetColor();
        typeInput = Console.ReadLine();
        isTypeInt = int.TryParse(typeInput, out intTypeInput);
    }

    if (isTypeInt)
    {
        if (intTypeInput != 1 && intTypeInput != 2) //If input is not 1 or 2
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("Ange (1) för laptop och (2) för mobiltelefon: ");
            Console.ResetColor();
            typeInput = Console.ReadLine();
            isTypeInt = int.TryParse(typeInput, out intTypeInput);
        }

        if (intTypeInput == 1) //Add product to asset list - laptop type
        {
            assets.Add(new Laptop("Laptop", brand, model, purchaseDate, price));
            l.AddedMessage();

        }
        else if (intTypeInput == 2) //Add product to asset list - mobile phone type
        {
            assets.Add(new MobilePhone("Mobile phone", brand, model, purchaseDate, price));
            m.AddedMessage();
        }
    }
}

//Asset list sorted by type, then purchase date
List<Asset> sortedList = assets.OrderBy(a => a.Type).ThenBy(a => a.PurchaseDate).ToList();

if (sortedList.Count() == 0)
{
    Console.WriteLine();
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Listan med tillgångar är tom...");
    Console.ResetColor();
}
else
{
    // * DISPLAY ASSETS
    Console.WriteLine();
    Console.ForegroundColor = ConsoleColor.DarkMagenta;
    Console.WriteLine("Type".PadRight(20) + "Brand".PadRight(20) + "Model".PadRight(20) + "Purchase Date".PadRight(20) + "Price");
    Console.ResetColor();
    Console.WriteLine("----------------------------------------------------------------------------------------------------");

    foreach (Asset asset in sortedList)
    {
        asset.Print();
    }
}

Console.ReadLine();