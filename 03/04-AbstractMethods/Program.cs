public class Program
{
    public static void Main(string[] args)
    {
        // Cannot create an instance of an abstract class directly:
        // Animal myAnimal = new Animal(); // This would cause a compilation error.

        // Create instances of concrete classes that inherit from Animal
        Dog myDog = new Dog();
        Cat myCat = new Cat();
        Bird myBird = new Bird();

        // Use the methods
        myDog.MakeSound();
        myDog.Move();
        myDog.Eat();

        Console.WriteLine();

        myCat.MakeSound();
        myCat.Move();
        myCat.Eat();

        Console.WriteLine();

        myBird.MakeSound();
        myBird.Move();
        myBird.Eat();

        Console.WriteLine();

        // Polymorphism with abstract classes
        Animal[] animals = new Animal[] { myDog, myCat, myBird };

        foreach (Animal animal in animals)
        {
            Console.WriteLine($"Type: {animal.GetType().Name}");
            animal.MakeSound();
            animal.Move();
            animal.Eat();
            Console.WriteLine();
        }
    }
}