Console.WriteLine("How many chocolate eggs were gathered today?");
Console.Write("> ");

var eggsCollected = Convert.ToInt32(Console.ReadLine());

var eggsForDuckbear = eggsCollected % 4;
var eggsForEachSister = (eggsCollected - eggsForDuckbear) / 4;

Console.WriteLine("Each of the sisters should get " + eggsForEachSister + " and the Duckbear the remaining " + eggsForDuckbear + " eggs.");