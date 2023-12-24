// Non-decimal numbers
byte byteNum = 12;
short shortNum = 3920;
int intNum = 150000;
long longNum = 213983837293;
sbyte sByteNum = -54;
ushort uShortNum = 64839;
uint uIntNum = 2387947839;
ulong uLongNum = 11749847028564928364;
    
// Decimal numbers    
float floatNum = 3.456f;
double doubleNum = 3.456;
decimal decimalNum = 3.456m;
    
// Character variables    
char charVar = 'a';
string stringVar = "Hello World!";

// True/False    
bool testBool = false;

// Print everything out
Console.WriteLine("The Variable Shop - Currently in stock:");
Console.WriteLine("Byte: " + byteNum + "\nShort: " + shortNum + "\nInt: " + intNum + "\nLong: " + longNum +
                  "\nSigned Byte: " + sByteNum + "\nUnsigned Short: " + uShortNum + "\nUnsigned Int: " + uIntNum + "\nUnsigned Long: " + uLongNum);
Console.WriteLine("\nDouble: " + doubleNum + "\nFloat: " + floatNum + "\nDecimal: " + decimalNum);
Console.WriteLine("\nChar: " + charVar + "\nString: " + stringVar);
Console.WriteLine("\nBool: " + testBool);

// The Variable Shop Returns:
byteNum = 21;
shortNum = 4839;
intNum = 594394;
longNum = 118283837293;
sByteNum = -83;
uShortNum = 50392;
uIntNum = 3495483028;
uLongNum = 8473927048773829128;

doubleNum = 493.382;
floatNum = 493.382f;
decimalNum = 493.382m;

charVar = 'b';
stringVar = "Goodbye World!";

testBool = true;

Console.WriteLine("The Variable Shop Returns! - Currently in stock:");
Console.WriteLine("Byte: " + byteNum + "\nShort: " + shortNum + "\nInt: " + intNum + "\nLong: " + longNum +
                  "\nSigned Byte: " + sByteNum + "\nUnsigned Short: " + uShortNum + "\nUnsigned Int: " + uIntNum + "\nUnsigned Long: " + uLongNum);
Console.WriteLine("\nDouble: " + doubleNum + "\nFloat: " + floatNum + "\nDecimal: " + decimalNum);
Console.WriteLine("\nChar: " + charVar + "\nString: " + stringVar);
Console.WriteLine("\nBool: " + testBool);