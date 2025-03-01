using System;

// Abstract base class: Shape
public abstract class Shape
{
    public abstract double CalculateArea();
    public virtual void Draw()
    {
        Console.WriteLine("Drawing a generic shape.");
    }
}

// Concrete class: Circle
public class Circle : Shape
{
    public double Radius { get; set; }

    public Circle(double radius)
    {
        Radius = radius;
    }

    public override double CalculateArea()
    {
        return Math.PI * Radius * Radius;
    }

    public override void Draw()
    {
        Console.WriteLine($"Drawing a Circle with radius: {Radius}");
    }
}

// Concrete class: Rectangle
public class Rectangle : Shape
{
    public double Width { get; set; }
    public double Height { get; set; }

    public Rectangle(double width, double height)
    {
        Width = width;
        Height = height;
    }

    public override double CalculateArea()
    {
        return Width * Height;
    }

    public override void Draw()
    {
        Console.WriteLine($"Drawing a Rectangle with width: {Width} and height: {Height}");
    }
}

// Concrete class: Triangle
public class Triangle : Shape
{
    public double Base { get; set; }
    public double Height { get; set; }

    public Triangle(double baseLength, double height)
    {
        Base = baseLength;
        Height = height;
    }

    public override double CalculateArea()
    {
        return 0.5 * Base * Height;
    }

    public override void Draw()
    {
        Console.WriteLine($"Drawing a Triangle with base: {Base} and height: {Height}");
    }
}

