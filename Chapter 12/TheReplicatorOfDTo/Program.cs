// Filling the first array
int[] firstArr = new int[5];
for (int i = 0; i < 5; i++)
{
    Console.Write("Give a number: ");
    firstArr[i] = Convert.ToInt32(Console.ReadLine());
}

// Copying all contents of the first array to the second
int[] secondArr = new int[5];
for(int i = 0; i < 5; i++) secondArr[i] = firstArr[i];

// Displaying everything
for(int i = 0; i < 5; i++) Console.WriteLine("First and second array at index " + i + ": " + firstArr[i] + " | " + secondArr[i]);