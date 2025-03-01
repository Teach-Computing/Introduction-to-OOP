using System;

class BaseClass
{
    public void ShowMessage()
    {
        Console.WriteLine("Message from BaseClass");
    }
}

class DerivedClass : BaseClass
{
    public void Display()
    {
        Console.WriteLine("Message from DerivedClass");
    }
}