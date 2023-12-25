Console.Write("Give an x value: ");
var x = Convert.ToInt32(Console.ReadLine());

Console.Write("Give a y value: ");
var y = Convert.ToInt32(Console.ReadLine());

string enemyLocation = "";

if (y > 0)
{
    if (x < 0) enemyLocation = "northwest";
    else if (x == 0) enemyLocation = "north";
    else enemyLocation = "northeast";
} else if (y == 0)
{
    if (x < 0) enemyLocation = "west";
    else if (x > 0) enemyLocation = "east";
}
else
{
    if (x < 0) enemyLocation = "southwest";
    else if (x == 0) enemyLocation = "south";
    else enemyLocation = "southeast";
}

Console.Write("The enemy is ");
if(x == 0 && y == 0) Console.WriteLine("here!");
else Console.WriteLine("to the " + enemyLocation);