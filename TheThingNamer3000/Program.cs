Console.WriteLine("What kind of thing are we talking about?");
string a = Console.ReadLine(); // Stores the thing name
Console.WriteLine("How would you describe it? Big? Azure? Tattered?");
string b = Console.ReadLine(); // Stores descriptive adjective of thing
string c = "of Doom"; // Stores the suffix "of Doom"
string d = "3000"; // Stores the number 300 as a String
Console.WriteLine("The " + b + " " + a + /*" of "*/ " " + c + " " + d + "!"); // Fixed double printing of "of"

/* Question: Aside from comments what else could you do to make this code more understandable?
 *
 * You could change the variable names to actively reflect what they're storing to
 * improve legibility and clear understanding of each. 
*/