using System;

class Program
{
    static void Main(string[] args)
    {
        // Calling a method
        GreetUser();

        // Calling a method with parameters
        GreetUser("Alice");

        // Calling a method with a return value
        int sum = AddNumbers(5, 3);
        Console.WriteLine($"The sum is {sum}");

        // Calling overloaded methods
        Console.WriteLine(AddNumbers(5, 3));
        Console.WriteLine(AddNumbers(5, 3, 2));
    }

    // Method definition
    static void GreetUser()
    {
        Console.WriteLine("Hello, User!");
    }

    // Method definition with parameters
    static void GreetUser(string name)
    {
        Console.WriteLine($"Hello, {name}!");
    }


     // Method definition with return value
    static int AddNumbers(int a, int b)
    {
        return a + b;
    }


    static int AddNumbers(int a, int b, int c)
    {
        return a + b + c;
    }
}