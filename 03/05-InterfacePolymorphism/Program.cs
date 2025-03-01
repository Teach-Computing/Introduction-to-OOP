
public class Program
{
    public static void Main(string[] args)
    {
        // Polymorphic collection of shapes
        IShape[] shapes = new IShape[]
        {
            new Circle(5),
            new Rectangle(4, 6),
            new Triangle(3, 8)
        };

        // Demonstrate polymorphism by iterating through the shapes
        foreach (IShape shape in shapes)
        {
            Console.WriteLine($"Area: {shape.CalculateArea()}");
            shape.Draw();
            Console.WriteLine();
        }

        // Example of a single shape being treated polymorphically.
        IShape myCircle = new Circle(10);
        Console.WriteLine($"My Circle Area: {myCircle.CalculateArea()}");
        myCircle.Draw();
    }
}