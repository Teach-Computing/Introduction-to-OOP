using System;

public class Animal
{
    // A virtual method that can be overridden by derived classes.
    public virtual void MakeSound()
    {
        Console.WriteLine("Animal makes a generic sound.");
    }

    public virtual void Move()
    {
        Console.WriteLine("Animal moves.");
    }

    public void Eat()
    {
        Console.WriteLine("Animal eats.");
    }
}

public class Dog : Animal
{
    // Override the virtual MakeSound method.
    public override void MakeSound()
    {
        Console.WriteLine("Dog barks: Woof!");
    }

    public override void Move()
    {
        Console.WriteLine("Dog runs.");
    }
}

public class Cat : Animal
{
    // Override the virtual MakeSound method.
    public override void MakeSound()
    {
        Console.WriteLine("Cat meows: Meow!");
    }

    public override void Move()
    {
        Console.WriteLine("Cat walks gracefully.");
    }
}

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

