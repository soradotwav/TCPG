Console.WriteLine("How many provinces do you have?");
Console.Write("> ");
var numProvinces = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("How many duchies do you have?");
Console.Write("> ");
var numDuchies = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("How many estates do you have?");
Console.Write("> ");
var numEstates = Convert.ToInt32(Console.ReadLine());

var totalScore = numProvinces * 6 + numEstates + numDuchies * 3;

Console.WriteLine("Your total score is " + totalScore + ".");