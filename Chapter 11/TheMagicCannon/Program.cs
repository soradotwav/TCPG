for (var i = 1; i <= 100; i++)
{
    
    Console.Write(i + ": "); // Print the attack number
    
    if(i % 3 == 0 && i % 5 == 0)
    {
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("Combined Blast");
    }
    else if (i % 3 == 0)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Fire");
    }
    else if (i % 5 == 0)
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("Electric");
    }
    else Console.WriteLine("Normal");

    Console.ForegroundColor = ConsoleColor.Gray; // Reset color to gray
}