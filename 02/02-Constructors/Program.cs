using System;

class Car
{
    public string Brand;
    public string Model;
    public int Year;

    // Default Constructor (No parameters)
    public Car()
    {
        Brand = "Unknown";
        Model = "Unknown";
        Year = 0;
    }

    // Parameterized Constructor
    public Car(string brand, string model, int year)
    {
        Brand = brand;
        Model = model;
        Year = year;
    }

    // Constructor with only brand and model
    public Car(string brand, string model)
    {
        Brand = brand;
        Model = model;
        Year = 2024; // Default year
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Car: {Brand} {Model}, Year: {Year}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Using the default constructor
        Car car1 = new Car();
        car1.DisplayInfo(); // Output: Car: Unknown Unknown, Year: 0

        // Using the parameterized constructor
        Car car2 = new Car("Toyota", "Corolla", 2022);
        car2.DisplayInfo(); // Output: Car: Toyota Corolla, Year: 2022

        // Using the constructor with only brand and model
        Car car3 = new Car("Honda", "Civic");
        car3.DisplayInfo(); // Output: Car: Honda Civic, Year: 2024
    }
}
