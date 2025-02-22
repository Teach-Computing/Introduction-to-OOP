// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
using System;

class Program
{
    static void Main(string[] args)
    {
        //for loop
        Console.WriteLine("For Loop Example:");
        for (int i = 1; i <= 5; i++)
        {
            Console.WriteLine($"Iteration {i}");
        }

        //while loop
        Console.WriteLine("While Loop Example:");
        int i = 1;
        while (i <= 5)
        {
            Console.WriteLine($"Iteration {i}");
            i++;
        }

        //do while loop
        Console.WriteLine("Do-While Loop Example:");
        int i = 1;
        do
        {
            Console.WriteLine($"Iteration {i}");
            i++;
        } while (i <= 5);

        //foreach loop
        Console.WriteLine("Foreach Loop Example:");
        string[] fruits = { "Apple", "Banana", "Cherry" };

        foreach (string fruit in fruits)
        {
            Console.WriteLine(fruit);
        }


        // Declare and initialize a list
        List<string> fruits = new List<string> { "Apple", "Banana", "Cherry" };

        // Add elements to the list
        fruits.Add("Date");

        // Access and print list elements
        foreach (string fruit in fruits)
        {
            Console.WriteLine(fruit);
        }
    }
}