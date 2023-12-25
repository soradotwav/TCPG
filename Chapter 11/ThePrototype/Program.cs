int user1Input;

do
{
    Console.Write("User 1, enter a number between 0 and 100: ");
    user1Input = Convert.ToInt16(Console.ReadLine());
    
} while (user1Input < 0 || user1Input > 100);
Console.Clear();

int user2Guess;

Console.WriteLine("User 2, guess the number.");
do
{
    Console.Write("What is your next guess? ");
    user2Guess = Convert.ToInt32(Console.ReadLine());
    
    if(user2Guess > user1Input) Console.WriteLine(user2Guess + " is too high.");
    else if (user2Guess < user1Input) Console.WriteLine(user2Guess + " is too low.");
} while(user2Guess != user1Input);

Console.Clear();
Console.WriteLine("You guessed the number!");