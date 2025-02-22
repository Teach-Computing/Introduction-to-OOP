using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please enter a number");
        int number = Convert.ToInt32(Console.ReadLine());
        if (number > 0)
        {
            Console.WriteLine("The number is positive");
        }
        else if (number < 0)
        {
            Console.WriteLine("The number is negative");
        }
        else
        {
            Console.WriteLine("The number is zero");
        }



        Console.WriteLine("Enter a grade (A, B, C, D, F):");
            char grade = Convert.ToChar(Console.ReadLine().ToUpper());

            switch (grade)
            {
                case 'A':
                    Console.WriteLine("Excellent!");
                    break;
                case 'B':
                    Console.WriteLine("Good job!");
                    break;
                case 'C':
                    Console.WriteLine("Well done!");
                    break;
                case 'D':
                    Console.WriteLine("You passed.");
                    break;
                case 'F':
                    Console.WriteLine("Better try again.");
                    break;
                default:
                    Console.WriteLine("Invalid grade.");
                    break;
            }
    }
}