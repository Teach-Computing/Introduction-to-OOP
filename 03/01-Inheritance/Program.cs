class Program
{
    static void Main()
    {
        DerivedClass obj = new DerivedClass();
        obj.ShowMessage();  // Inherited method
        obj.Display();      // Derived class method
    }
}