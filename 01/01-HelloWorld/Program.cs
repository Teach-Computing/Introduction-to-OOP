//output a string
Console.WriteLine("Hello C#");

//output a number
int x = 10;
Console.WriteLine(x);

//output a formatted string
Console.WriteLine($"The value of x is {x}");

//output a boolean
bool y = true;
Console.WriteLine(y);

//output a double
double z = 3.14159;
Console.WriteLine(z);


//concatenate strings
string firstName = "John";
string lastName = "Doe";    
Console.WriteLine($"My name is {firstName} {lastName}");

//concatenate numbers
int a = 10;
int b = 20;
Console.WriteLine($"The sum of {a} and {b} is {a + b}");

//concatenate booleans
bool c = true;
bool d = false;
Console.WriteLine($"The result of {c} and {d} is {c && d}");


//formated double precision
Console.WriteLine($"The value of z is {z:f3}");

//adjust the width of the output
Console.WriteLine($"The value of x is {x,7}");

//adjust the precision of the output
Console.WriteLine($"The value of z is {z,7:f4}");


//Console.BackgroundColor = ConsoleColor.Yellow;
Console.ForegroundColor = ConsoleColor.Red; // Change text color for contrast
Console.WriteLine("This Red text");

Console.ResetColor();
Console.WriteLine("Back to normal colors");

