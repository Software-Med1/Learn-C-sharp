var name = "Sheriff";
string surname = "Akinsanya";
var Pro = "C#";

Console.WriteLine($"Hello, World! \nMy name is {surname} {name}, i'm a software Engineer and we are learning {Pro} today. \nWelcome !!!");

float num = 4.34F;
var d = 5.3F;

Console.WriteLine(num + d);

// C# LIST 
var names = new List<string> { "water", "house", "horse", "Homes", "Holmes", "Sherlock" };

List<string> fruits = new List<string> { "Apple", "Banana", "Cherry" };


foreach (var ae in fruits)
{
    // Console.WriteLine(ae);
}

foreach (var ae in fruits)
{
    Console.WriteLine(ae);
}

Console.WriteLine(names[0]); // First object of List
Console.WriteLine(names[2]); // nth object of List
Console.WriteLine(names[^1]);// Last object of List


foreach (var item in names)
{
    Console.WriteLine(item);
}

// IF STATEMENT
var cass = false;
if (cass)
{
    Console.WriteLine("its true");
}
else
{
    Console.WriteLine("its false");
}


// FOR LOOP
for (var i = 0; i < 5; i++)
{
    Console.WriteLine($"Displaying number {i}");
}