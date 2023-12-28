// Set initial state as "locked"
ChestState current = ChestState.Locked;

// Main loop; runs until an empty string is entered
while(true)
{
    Console.Write("The chest is " + current.ToString().ToLower() + ". What do you want to do? ");
    var userIn = Console.ReadLine();

    if (userIn.Equals("")) break;
    EvaluateUserInput(userIn);
}

// Evaluates the user input and updates the chest state accordingly.
void EvaluateUserInput(String input)
{
    if (current == ChestState.Locked && EqualsIgnoreCase(input, "unlock") ||
        current == ChestState.Open && EqualsIgnoreCase(input, "close"))
        current = ChestState.Closed;
    else if (current == ChestState.Closed)
    {
        if (EqualsIgnoreCase(input, "lock"))
            current = ChestState.Locked;
        else if (EqualsIgnoreCase(input, "open"))
            current = ChestState.Open;
    }
}

// Helper function to compare two strings without considering case sensitivity.
bool EqualsIgnoreCase(string input, string input2) => String.Equals(input, input2, StringComparison.OrdinalIgnoreCase);

/// <summary>
/// Represents the possible states of the chest.
/// </summary>
enum ChestState {Open, Closed, Locked}