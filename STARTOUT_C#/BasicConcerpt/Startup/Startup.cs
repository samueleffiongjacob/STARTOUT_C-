using System;
using System.Collections.Generic;
using System.Text;

namespace STARTOUT_C_.BasicConcerpt.Startup
{
    class Startup
    {
        public static void DataTypesExample()
        {
            Console.WriteLine("\n=== DATA TYPES EXAMPLE ===");
            int WholeNumber = 120;
            string Anytext = "Name or other Things";
            double ldecimalPoint = 45.84;
            bool TrueFalse = false;
            char SingleLetter = 'a';

            Console.WriteLine(WholeNumber + " " + SingleLetter);
        }

        public static void ConstantsExample()
        {
            Console.WriteLine("\n=== CONSTANTS EXAMPLE ===");
            const int Num = 12;
            const string Text = "constant text";
            Console.WriteLine("Working with constants: " + Num + "\n" + Text);

            // Multiple Variables
            const int x = 2, y = 3, z = 4;
            Console.WriteLine("Multiple Variables: x + y + z = " + (x + y + z));
        }

        public static void StringOperationsExample()
        {
            Console.WriteLine("\n=== STRING OPERATIONS EXAMPLE ===");
            const string Text = "constant text";
            Console.WriteLine("String length: " + Text.Length);

            Console.Write("Enter name to convert to UPPER case: ");
            string upperInput = Console.ReadLine();
            Console.WriteLine(upperInput.ToUpper());

            Console.Write("Enter name to convert to lower case: ");
            string lowerInput = Console.ReadLine();
            Console.WriteLine(lowerInput.ToLower());

            // String concatenation
            string firstName = "John ";
            string lastName = "Doe";
            string names = string.Concat(firstName, lastName);
            Console.WriteLine("Concatenation: " + names);

            // String Interpolation
            string fullName = $"My full name is {firstName}{lastName}";
            Console.WriteLine("Interpolation: " + fullName);
        }
    }
}
