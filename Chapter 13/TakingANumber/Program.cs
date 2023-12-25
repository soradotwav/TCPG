/// <summary>
/// Takes an input question and returns the int answer from the user.
/// </summary>
int AskForNumber(string text)
{
    Console.WriteLine(text);
    Console.Write("> ");
    return Convert.ToInt32(Console.ReadLine());
}

/// <summary>
/// Takes an input question and a range and asks the user for a number until its in the valid range,
/// then returns the valid input
/// </summary>
int AskForNumberInRange(string text, int min, int max)
{
    int userNum = min;
    do
    {
        Console.WriteLine(text);
        Console.Write("> ");
        userNum = Convert.ToInt32(Console.ReadLine());
    } while (userNum < min || userNum > max);

    return userNum;
} 

// Too lazy to add it to a previous challenge but you get the point