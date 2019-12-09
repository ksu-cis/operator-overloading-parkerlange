using System;

namespace VectorMath
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Fun with vectors");
            Vector3 one = new Vector3(3, 4, 5);
            Vector3 two = new Vector3(4, 8, 0);
            Vector3 three = new Vector3(4, 8, 0);

            Console.WriteLine($"Static method Add: {Vector3.Add(one, two)}");
            Console.WriteLine($"Object method Add: {one.Add(two)}");
            Console.WriteLine($"Opertator: {one + two}");

            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("Subtraction");
            Console.WriteLine($"Opertator: {one - two}");

            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("Multiplication");
            Console.WriteLine($"Opertator: {2 * one}");

            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("Comparison");
            Console.WriteLine($"Opertator: {one == two}");
            Console.WriteLine($"Opertator: {two == three}");

            Console.WriteLine("-------------------------------------------");
            Console.WriteLine($"Opertator: {one++}");
            Console.WriteLine($"Magnitude: {~one}");
            if (one)
            {
                Console.WriteLine($"{one} is Truthy");

            }
            else
            {
                Console.WriteLine($"{one} is Falsy");
            }

            if (Vector3.Zero)
            {
                Console.WriteLine($"{one} is Truthy");

            }
            else
            {
                Console.WriteLine($"{one} is Falsy");
            }
        }
    }
}
