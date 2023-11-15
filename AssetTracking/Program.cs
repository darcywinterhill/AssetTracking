using AssetTracking;

Console.WriteLine("Här kan du hantera dina tillgångar!");
Console.WriteLine("För att se en lista över dina tillgångar, skriv 'exit'.");
Console.WriteLine();

List<Asset> assets = new List<Asset>();

void AddedMessage() //Method to display message when product is added
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("Produkten lades till");
    Console.ResetColor();
}



while (true)
{
    Console.WriteLine("-------------------------------------------------");
    Console.WriteLine(" >>>LÄGG TILL PRODUKT<<<");
    Console.WriteLine();
    Console.Write(" >> Ange märke: "); //Brand input
    string brand = Console.ReadLine();

    if (brand.ToLower().Trim() == "exit")
    {
        break;
    }

    Console.Write(" >> Ange modell: "); //Model input
    string model = Console.ReadLine();

    if (model.ToLower().Trim() == "exit")
    {
        break;
    }

    Console.Write(" >> Ange inköpsdatum (YYYY/MM/DD: "); //Purcahse date input
    string dateInput = Console.ReadLine();

    if (dateInput.ToLower().Trim() == "exit")
    {
        break;
    }

    DateTime purchaseDate = Convert.ToDateTime(dateInput);

    Console.Write(" >> Ange pris: "); //Price input
    string priceInput = Console.ReadLine();

    if (dateInput.ToLower().Trim() == "exit")
    {
        break;
    }

    bool isPriceInt = int.TryParse(priceInput, out int price);

    //Error handling for wrong type input
    if (!isPriceInt) //If input is not an int
    {
        while (!isPriceInt)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("Ange ett pris (siffror): ");
            Console.ResetColor();
            priceInput = Console.ReadLine();
            isPriceInt = int.TryParse(priceInput, out price);
        }
    }

    Console.Write(" >> Är det en (1) laptop eller (2) mobiltelefon du vill lägga till? "); //Type input
    string typeInput = (Console.ReadLine());

    bool isInt = int.TryParse(typeInput, out int intTypeInput);

    //Error handling for wrong type input
    if (!isInt) //If input is not an int
    {
        while (!isInt)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("Ange en siffra, (1) för laptop och (2) för mobiltelefon: ");
            Console.ResetColor();
            typeInput = Console.ReadLine();
            isInt = int.TryParse(typeInput, out intTypeInput);
        }
    }

    if (isInt)
    {
        if (intTypeInput != 1 && intTypeInput != 2) //If input is not 1 or 2
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("Ange (1) för laptop och (2) för mobil: ");
            Console.ResetColor();
            typeInput = Console.ReadLine();
            isInt = int.TryParse(typeInput, out intTypeInput);
        }

        if (intTypeInput == 1) //Add product to asset list - laptop type
        {

            assets.Add(new Laptop("Laptop", brand, model, purchaseDate, price));
            AddedMessage();
        }
        else if (intTypeInput == 2) //Add product to asset list - mobile phone type
        {
            assets.Add(new MobilePhone("Mobile phone", brand, model, purchaseDate, price));
            AddedMessage();
        }
    }
}
List<Asset> sortedList = assets.OrderBy(c => c.Type).ThenBy(c => c.PurchaseDate).ToList();

//Display assets
Console.WriteLine();
Console.WriteLine("Type".PadRight(20) + "Brand".PadRight(20) + "Model".PadRight(20) + "Purchase Date".PadRight(20) + "Price");
Console.WriteLine("----------------------------------------------------------------------------------------------------");
foreach (Asset asset in sortedList)
{
    asset.Print();
}

Console.ReadLine();