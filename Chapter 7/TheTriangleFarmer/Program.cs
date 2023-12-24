Console.Write("Triangle base: ");
var triangleBase = Convert.ToInt32(Console.ReadLine());

Console.Write("Triangle height: ");
var triangleHeight = Convert.ToInt32(Console.ReadLine());

var triangleArea = (triangleBase * triangleHeight) / 2d;

Console.WriteLine("The area of the triangle is " + triangleArea);