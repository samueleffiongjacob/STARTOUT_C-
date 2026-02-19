using System;
using System.Collections.Generic;
using System.Linq; // for max, min
using System.Text;
//using static System.Runtime.InteropServices.JavaScript.JSType;

namespace STARTOUT_C_.BasicConcerpt.Arrays
{
    class ArraysItem
    {
        static void ItemArray()
        {
            /* Create an Array
            Arrays are used to store multiple values in a single variable, instead of declaring separate variables for each value.

            To declare an array, define the variable type with square brackets:

            string[] cars;
            We have now declared a variable that holds an array of strings.

            To insert values to it, we can use an array literal - place the values in a comma-separated list, inside curly braces:
            */

            string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };

            int[] myNum = { 10, 20, 30, 40 };

            // Create an array of four elements, and add values later
            string[] cars1 = new string[4];

            // Create an array of four elements and add values right away 
            string[] cars2 = new string[4] { "Volvo", "BMW", "Ford", "Mazda" };

            // Create an array of four elements without specifying the size 
            string[] cars3 = new string[] { "Volvo", "BMW", "Ford", "Mazda" };

            // Create an array of four elements, omitting the new keyword, and without specifying the size

            string[] cars4 = { "Volvo", "BMW", "Ford", "Mazda" };

            //However, you should note that if you declare an array and initialize it later, you have to use the new keyword:
            // access cars
            Console.WriteLine(cars.Length + " " + cars[0]);
        }

        public static void ItemArrays()
        {
            // view cars
            Console.WriteLine("array \n");
            ItemArray();
        }

        static void LoopedWhileArray()
        {
            /* Loop Through an Array
            You can loop through the array elements with the for loop, and use the Length property to specify how many times the loop should run.

            The following example outputs all elements in the cars array:
            */
            string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };
            for (int i = 0; i < cars.Length; i++)
            {
                Console.WriteLine(cars[i]);
            }
        }

        static void ForEachArray()
        {
            /*
             * The foreach Loop
               There is also a foreach loop, which is used exclusively to loop through elements in an array:

               foreach (type variableName in arrayName) 
               {
                  // code block to be executed
               }

               The following example outputs all elements in the cars array, using a foreach loop:
            */

            string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };
            foreach (string i in cars)
            {
                Console.WriteLine(i);
            }

            /*
             * The example above can be read like this: for each string element (called i - as in index) in cars, print out the value of i.
               If you compare the for loop and foreach loop, you will see that the foreach method is easier to write, it does not require a counter (using the Length property), and it is more readable.
            */
        }

        public static void WhilwQue()
        {
            Console.WriteLine("new while and for loop for array\n");
            ForEachArray();
            Console.WriteLine("new while and for loop for array\n");
            LoopedWhileArray();
        }

        // C# Sort Arrays
        /* Sort an Array
        There are many array methods available, for example Sort(), which sorts an array alphabetically or in an ascending order:
        */

        // Sort a string 
        static void SortArrays()
        {
            string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };
            Array.Sort(cars);

            foreach (string i in cars)
            {
                Console.WriteLine(i);
            }
        }

        static void SortNumber()
        {
            // Sort an Int 
            int[] myNumbers = { 5, 1, 8, 9 };
            Array.Sort(myNumbers);

            foreach (int i in myNumbers)
            {
                Console.WriteLine(i);
            }
        }

        static void SystemLinq()
        {
            /*
            * System.Linq Namespace
               Other useful array methods, such as Min, Max, and Sum, can be found in the System.Linq namespace:

               using System.Linq;
            */

            int[] myNumbers = { 5, 1, 8, 9 };
            Console.WriteLine(myNumbers.Max());  // returns the largest value
            Console.WriteLine(myNumbers.Min());  // returns the smallest value
            Console.WriteLine(myNumbers.Sum());  // returns the sum of elements
        }

        public static void PlantQue()
        {
            Console.WriteLine("\n=== SORT & LINQ EXAMPLES ===\n");
            Console.WriteLine("--- System.Linq Methods ---");
            SystemLinq();
            Console.WriteLine("\n--- Sort Numbers ---");
            SortNumber();
            Console.WriteLine("\n--- Sort Strings ---");
            SortArrays();
        }

        static void TwoArray()
        {
            int[,] numbers = { { 1, 4, 2 }, { 3, 6, 8 } };
            numbers[0, 0] = 5; // Change value to 5
            Console.WriteLine("new 2D \n" + numbers[0, 0]); // Outputs 5 instead of 1

            // FORLOOP
            foreach (int i in numbers)
            {
                Console.WriteLine("for loop \n" + i);
            }

            //  Also note that we have to use GetLength() instead of Length to specify how many times the loop should run:
            for (int i = 0; i < numbers.GetLength(0); i++)
            {
                for (int j = 0; j < numbers.GetLength(1); j++)
                {
                    Console.WriteLine("getLength arrays \n " + numbers[i, j]);
                }
            }
        }

        public static void TwoDimensionalarray()
        {
            TwoArray();
        }
    }
}