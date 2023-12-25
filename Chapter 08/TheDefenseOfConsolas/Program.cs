Console.Title = "Defense of Consolas";

Console.Write("Target Row: ");
var targetRow = Convert.ToByte(Console.ReadLine());

Console.Write("Target Column: ");
var targetColumn = Convert.ToByte(Console.ReadLine());

Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("(" + targetRow + ", " + Math.Clamp(targetColumn - 1, (byte)0, (byte)8) + ")");
Console.WriteLine("(" + Math.Clamp(targetRow - 1, (byte)0, (byte)8) + ", " + targetColumn + ")");
Console.WriteLine("(" + targetRow + ", " + Math.Clamp(targetColumn + 1, (byte)0, (byte)8) + ")");
Console.WriteLine("(" + Math.Clamp(targetRow + 1, (byte)0, (byte)8) + ", " + targetColumn + ")");

//Console.Beep(400, 500); --> Commented out due to it being unavailable on macOS