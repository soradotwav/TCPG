// Initialize base health stats.
var manticoreHealth = 10;
var cityHealth = 15;

// Player 1 stations the Manticore
Console.Write("Player 1, how far away from the city do you want to station the Manticore? ");
int manticoreDistance;

// Validate and get a valid distance
do
{
    manticoreDistance = Convert.ToInt32(Console.ReadLine());
    if (manticoreDistance < 0 || manticoreDistance > 100) Console.Write("Please enter a valid distance (0-100): ");
} while (manticoreDistance < 0 || manticoreDistance > 100);

Console.Clear();

Console.WriteLine("Player 2, it is your turn.");
var round = 1;

// Continue the game until either the city or the Manticore is defeated.
while (cityHealth > 0 && manticoreHealth > 0)
{
    PrintCurrentGameProgress(round++);
}

// Display the game result
if(manticoreHealth <= 0)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("The Manticore has been destroyed! The city of Consolas has been saved!");
}
else
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("The Manticore has succeeded in its goal. The city of Consolas has been destroyed.");
}

/// <summary>
/// Prints the current game progress/interface for a round.
/// </summary>
/// <param name="currRound">The current round number</param>
void PrintCurrentGameProgress(int currRound)
{
    Console.WriteLine("-------------------------------------------------------------");
    Console.WriteLine("STATUS: Round: {0} City: {1}/15 Manticore: {2}/10", currRound, cityHealth, manticoreHealth);
    var expectedDamage = CalculateExpectedDamage(currRound);
    Console.WriteLine("The cannon is expected to deal {0} damage this round.", expectedDamage);
    Console.Write("Enter the desired cannon range: ");
    CheckAndComputeForHit(Convert.ToInt32(Console.ReadLine()), expectedDamage);
}

// <summary>
/// Calculates the expected damage for a given round.
/// </summary>
/// <param name="currentTurn">The current round number</param>
/// <returns>The expected damage</returns>
int CalculateExpectedDamage(int currentTurn)
{
    if (currentTurn % 3 == 0 && currentTurn % 5 == 0) return 10;
    else if (currentTurn % 5 == 0 || currentTurn % 3 == 0) return 3;
    else return 1;
}

/// <summary>
/// Checks and computes the hit based on the cannon range.
/// </summary>
/// <param name="cannonRange">The chosen cannon range</param>
/// <param name="expectedDamage">The expected damage for the round</param>
void CheckAndComputeForHit(int canonRange, int expectedDamage)
{
    if(canonRange > manticoreDistance) Console.WriteLine("That round OVERSHOT the target.");
    else if (canonRange < manticoreDistance) Console.WriteLine("That round FELL SHORT of the target.");
    else
    {
        Console.WriteLine("That round was a DIRECT HIT!");
        manticoreHealth -= expectedDamage;
    }

    cityHealth--;
}