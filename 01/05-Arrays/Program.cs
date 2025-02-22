using System;

namespace _04_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declare and initialize an array
            int[] numbers = { 1, 2, 3, 4, 5 };

            // Access and print array elements
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }

            // Declare and initialize a 2D array
            int[,] matrix = {
                { 1, 2, 3 },
                { 4, 5, 6 },
                { 7, 8, 9 }
            };

            // Access and print 2D array elements
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
                
    }
}