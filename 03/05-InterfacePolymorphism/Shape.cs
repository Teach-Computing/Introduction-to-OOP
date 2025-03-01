using System;

// Interface defining common behavior for shapes
public interface IShape
{
    double CalculateArea();
    void Draw();
}

// Concrete class: Circle
public class Circle : IShape
{
    public double Radius { get; set; }

    public Circle(double radius)
    {
        Radius = radius;
    }

    public double CalculateArea()
    {
        return Math.PI * Radius * Radius;
    }

    public void Draw()
    {
        Console.WriteLine($"Drawing a Circle with radius: {Radius}");
    }
}

// Concrete class: Rectangle
public class Rectangle : IShape
{
    public double Width { get; set; }
    public double Height { get; set; }

    public Rectangle(double width, double height)
    {
        Width = width;
        Height = height;
    }

    public double CalculateArea()
    {
        return Width * Height;
    }

    public void Draw()
    {
        Console.WriteLine($"Drawing a Rectangle with width: {Width} and height: {Height}");
    }
}

// Concrete class: Triangle
public class Triangle : IShape
{
    public double Base { get; set; }
    public double Height { get; set; }

    public Triangle(double baseLength, double height)
    {
        Base = baseLength;
        Height = height;
    }

    public double CalculateArea()
    {
        return 0.5 * Base * Height;
    }

    public void Draw()
    {
        Console.WriteLine($"Drawing a Triangle with base: {Base} and height: {Height}");
    }
}
