Console.WriteLine("Please enter your name");
string name = Console.ReadLine();
Console.WriteLine($"Hello {name}");

//read numbers
Console.WriteLine("Please enter a number");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Please enter another number");
int number2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"The sum of {number} and {number2} is {number + number2}");

//read booleans
Console.WriteLine("Please enter a boolean");
bool boolean = Convert.ToBoolean(Console.ReadLine());
Console.WriteLine($"The boolean is {boolean}");