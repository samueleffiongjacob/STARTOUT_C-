using System;
using System.Collections.Generic;
using System.Text;

namespace STARTOUT_C_.BasicConcerpt.Method
{
    class Method
    {
        // Method declaration - no parameters, no return value
        static void Greet()
        {
            Console.WriteLine("Hello, World!");
        }

        // Method with parameters
        static void GreetPerson(string name)
        {
            Console.WriteLine($"Hello, {name}!");
        }

        // Method with return value
        static int Add(int a, int b)
        {
            return a + b;
        }

        // Method with multiple parameters and return value
        static int Multiply(int x, int y)
        {
            return x * y;
        }

        // Method with string return value
        static string GetFullName(string firstName, string lastName)
        {
            return firstName + " " + lastName;
        }

        // Method overloading - same name, different parameters
        static int Sum(int a, int b)
        {
            return a + b;
        }

        static double Sum(double a, double b)
        {
            return a + b;
        }

        public static void MethodExample()
        {
            Console.WriteLine("\n=== METHOD EXAMPLES ===");

            // Calling method without parameters
            Greet();

            // Calling method with parameters
            GreetPerson("Alice");
            GreetPerson("Bob");

            // Calling method with return value
            int sum = Add(5, 3);
            Console.WriteLine($"5 + 3 = {sum}");

            int product = Multiply(4, 7);
            Console.WriteLine($"4 * 7 = {product}");

            // String return value
            string fullName = GetFullName("John", "Doe");
            Console.WriteLine($"Full Name: {fullName}");

            // Method overloading
            Console.WriteLine($"Sum of integers: {Sum(5, 10)}");
            Console.WriteLine($"Sum of doubles: {Sum(5.5, 10.3)}");

            Console.WriteLine();
        }
    }
}