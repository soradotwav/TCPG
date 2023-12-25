// Display Shop Menu
Console.WriteLine("The following items are available:");
Console.WriteLine("1 - Rope");
Console.WriteLine("2 - Torches");
Console.WriteLine("3 - Climbing Equipment");
Console.WriteLine("4 - Clean Water");
Console.WriteLine("5 - Machete");
Console.WriteLine("6 - Canoe");
Console.WriteLine("7 - Food Supplies");

Console.Write("\nWhat number do you want to see the price of? ");
var userChoice = Convert.ToByte(Console.ReadLine());

double price = 0; // Specified as double for discounted inventory var handling
var item = "";

// User Choice handling
switch (userChoice)
{
    case 1:
        price = 10;
        item = "Torches";
        break;
    case 2:
        price = 15;
        item = "Torches";
        break;
    case 3:
        price = 25;
        item = "Climbing Equipment";
        break;
    case 4:
        price = 1;
        item = "Clean Water";
        break;
    case 5:
        price = 20;
        item = "Machete";
        break;
    case 6:
        price = 200;
        item = "Canoe";
        break;
    case 7:
        price = 1;
        item = "Food Supplies";
        break;
}

// Addition for Discounted Inventory
Console.Write("What is your name? ");
price = Console.ReadLine() switch
{
    "Marvin" => price / 2,
    _ => price
};

// Print user choice prices
if(userChoice > 0 && userChoice < 8) Console.WriteLine("\n" + item + " cost " + price + " gold.");
else Console.WriteLine("\nI'm sorry, I do not have that item available.");