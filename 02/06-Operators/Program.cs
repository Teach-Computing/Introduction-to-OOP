using System;

namespace ComplexNumberDemo
{
    class ComplexNumber
    {
        // Automatic Properties for Real and Imaginary parts.
        public double Real { get; set; }
        public double Imaginary { get; set; }

        // Constructor to initialize a complex number.
        public ComplexNumber(double real, double imaginary)
        {
            Real = real;
            Imaginary = imaginary;
        }

        // Copy Constructor: Creates a new ComplexNumber by copying an existing one.
        public ComplexNumber(ComplexNumber other)
        {
            Real = other.Real;
            Imaginary = other.Imaginary;
        }

        // Operator Overloading for Addition.
        public static ComplexNumber operator +(ComplexNumber c1, ComplexNumber c2)
        {
            return new ComplexNumber(c1.Real + c2.Real, c1.Imaginary + c2.Imaginary);
        }

        // Operator Overloading for Subtraction.
        public static ComplexNumber operator -(ComplexNumber c1, ComplexNumber c2)
        {
            return new ComplexNumber(c1.Real - c2.Real, c1.Imaginary - c2.Imaginary);
        }

        // Operator Overloading for Multiplication.
        public static ComplexNumber operator *(ComplexNumber c1, ComplexNumber c2)
        {
            double realPart = c1.Real * c2.Real - c1.Imaginary * c2.Imaginary;
            double imaginaryPart = c1.Real * c2.Imaginary + c1.Imaginary * c2.Real;
            return new ComplexNumber(realPart, imaginaryPart);
        }

        // Operator Overloading for Equality.
        public static bool operator ==(ComplexNumber c1, ComplexNumber c2)
        {
            // Check for nulls to avoid NullReferenceException.
            if (ReferenceEquals(c1, null) && ReferenceEquals(c2, null))
                return true;
            if (ReferenceEquals(c1, null) || ReferenceEquals(c2, null))
                return false;

            return c1.Real == c2.Real && c1.Imaginary == c2.Imaginary;
        }

        public static bool operator !=(ComplexNumber c1, ComplexNumber c2)
        {
            return !(c1 == c2);
        }

        // Override Equals and GetHashCode for proper equality comparison.
        public override bool Equals(object obj)
        {
            if (obj is ComplexNumber other)
                return this == other;
            return false;
        }

        public override int GetHashCode()
        {
            return Real.GetHashCode() ^ Imaginary.GetHashCode();
        }

        // Assignment Overloading Workaround: Simulate deep copy using an Assign method.
        public void Assign(ComplexNumber other)
        {
            Real = other.Real;
            Imaginary = other.Imaginary;
        }

        // Override ToString for easy display.
        public override string ToString()
        {
            return $"{Real} + {Imaginary}i";
        }
    }

    class Program
    {
        static void Main()
        {
            // Create two ComplexNumber objects.
            ComplexNumber c1 = new ComplexNumber(2, 3);
            ComplexNumber c2 = new ComplexNumber(4, -1);

            Console.WriteLine("c1 = " + c1);
            Console.WriteLine("c2 = " + c2);

            // Operator Overloading: Addition
            ComplexNumber c3 = c1 + c2;
            Console.WriteLine("c1 + c2 = " + c3);

            // Operator Overloading: Subtraction
            ComplexNumber c4 = c1 - c2;
            Console.WriteLine("c1 - c2 = " + c4);

            // Operator Overloading: Multiplication
            ComplexNumber c5 = c1 * c2;
            Console.WriteLine("c1 * c2 = " + c5);

            // Using the Copy Constructor
            ComplexNumber c6 = new ComplexNumber(c1);
            Console.WriteLine("Copy of c1 (c6) = " + c6);

            // Using the Assign method to simulate assignment overloading
            c6.Assign(c2);
            Console.WriteLine("After assigning c2 to c6 = " + c6);
        }
    }
}
