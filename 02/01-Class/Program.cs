using System;

class Car
{
    // Public variables (fields)
    public string Brand;
    public string Model;
    public int Year;

    // Method to display car details
    public void DisplayInfo()
    {
        Console.WriteLine($"Car: {Brand} {Model}, Year: {Year}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Creating objects of the Car class
        Car myCar = new Car();
        myCar.Brand = "Toyota";
        myCar.Model = "Corolla";
        myCar.Year = 2022;

        Car yourCar = new Car();
        yourCar.Brand = "Honda";
        yourCar.Model = "Civic";
        yourCar.Year = 2021;

        // Calling method to display details
        myCar.DisplayInfo();
        yourCar.DisplayInfo();
    }
}

