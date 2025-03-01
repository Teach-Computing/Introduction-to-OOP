public class VirtualMethodDemo
{
    public static void Main(string[] args)
    {
        // Create an array of Animal objects, including instances of derived classes.
        Animal[] animals = new Animal[]
        {
            new Animal(),
            new Dog(),
            new Cat(),
            new Bird()
        };

        // Iterate through the array and call the MakeSound method.
        foreach (Animal animal in animals)
        {
            Console.WriteLine($"Type: {animal.GetType().Name}"); // Display the actual type
            animal.MakeSound(); // Polymorphic call: the correct MakeSound is called
            animal.Move();
            animal.Eat(); // Non-virtual method, same for all animals
            Console.WriteLine();
        }

        //Demonstrate a single virtual method call.
        Animal myDog = new Dog();
        myDog.MakeSound();

        //Demonstrate calling a virtual method on the base class.
        Animal genericAnimal = new Animal();
        genericAnimal.MakeSound();

    }
}