using System;

// Abstract class: Animal
public abstract class Animal
{
    // Abstract method: MakeSound (no implementation in the base class)
    public abstract void MakeSound();

    // Abstract method: Move (no implementation in the base class)
    public abstract void Move();

    // Non-abstract method (shared by all derived animals)
    public void Eat()
    {
        Console.WriteLine($"{this.GetType().Name} is eating.");
    }
}

// Concrete class: Dog (inherits from Animal)
public class Dog : Animal
{
    // Implementation of the abstract MakeSound method
    public override void MakeSound()
    {
        Console.WriteLine("Dog barks: Woof!");
    }

    // Implementation of the abstract Move method
    public override void Move()
    {
        Console.WriteLine("Dog runs.");
    }
}

// Concrete class: Cat (inherits from Animal)
public class Cat : Animal
{
    // Implementation of the abstract MakeSound method
    public override void MakeSound()
    {
        Console.WriteLine("Cat meows: Meow!");
    }

    // Implementation of the abstract Move method
    public override void Move()
    {
        Console.WriteLine("Cat walks gracefully.");
    }
}

// Concrete class: Bird (inherits from Animal)
public class Bird : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("Bird chirps: Tweet!");
    }

    public override void Move()
    {
        Console.WriteLine("Bird flies.");
    }
}

