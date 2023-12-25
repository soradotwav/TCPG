int[] array = new int[] { 4, 51, -7, 13, -99, 15, -8, 45, 90};

int currentSmallest = int.MaxValue;
foreach (int currInt in array)
{
    if (currInt < currentSmallest)
        currentSmallest = currInt;
}

Console.WriteLine(currentSmallest);