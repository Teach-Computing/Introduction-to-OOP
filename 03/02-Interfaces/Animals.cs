using System;

interface IAnimal
{
    void Speak();
}

interface IMammal
{
    void Run();
}

class Dog : IAnimal, IMammal
{
    public void Speak()
    {
        Console.WriteLine("Dog Barks");
    }

    public void Run()
    {
        Console.WriteLine("Dog Runs");
    }
}

class Program
{
    static void Main()
    {
        Dog d = new Dog();
        d.Speak();
        d.Run();
    }
}
