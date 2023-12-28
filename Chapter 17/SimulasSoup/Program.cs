// Define a tuple variable to store the user's selections for the soups ingredients
var userSoup = (FoodType: (FoodType)GetCurrChoice<FoodType>(), 
    MainIngred: (MainIngred)GetCurrChoice<MainIngred>(), 
    Seasoning: (Seasoning)GetCurrChoice<Seasoning>());

// Display the user's choices using string interpolation
Console.WriteLine($"You have made a {userSoup.Seasoning} {userSoup.MainIngred} {userSoup.FoodType}.");

// Generic method to get the user's choice from an enum
int GetCurrChoice<T>()
{
    var currArray = Enum.GetValues(typeof(T));
    int choice;
    
    do
    {
        var index = 1;
        
        // Display the available choices to the user
        foreach (T value in currArray)
            Console.WriteLine(index++ + ". " + value);
        
        Console.WriteLine("Pick an item from the list above to create your dish.");
        Console.Write("> ");
        choice = Convert.ToInt32(Console.ReadLine());
        
        // Validate the user's input and prompt for re-entry if invalid
        if(choice < 1 || choice > currArray.Length) Console.WriteLine("Invalid input. Please try again.");
    } while (choice < 1 || choice > currArray.Length);
    
    Console.Clear();
    
    // Return the user's choice (index adjusted to start from 0)
    return choice - 1;
}

// Individual Enums for each type of option
enum FoodType { Soup, Stew, Gumbo }
enum MainIngred { Mushrooms, Chicken, Carrots, Potatoes }
enum Seasoning { Spicy, Salty, Sweet }