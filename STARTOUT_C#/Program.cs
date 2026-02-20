using STARTOUT_C_.BasicConcerpt.Arrays;
using STARTOUT_C_.BasicConcerpt.Conditionals;
using STARTOUT_C_.BasicConcerpt.Loops;
using STARTOUT_C_.BasicConcerpt.Startup;
using STARTOUT_C_.BasicConcerpt.Switch;
using STARTOUT_C_.BasicConcerpt.Method;
using System;
using System.IO;


namespace STARTOUT_C_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to C# Programming! \n");

            // User Input Example

            Console.WriteLine("What's your name? ");
            string name = Console.ReadLine();
            Console.WriteLine("What's your age? ");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Hello {name}!");
            Console.WriteLine($"You're learning C# at age: {age}");
            age += 1;
            Console.WriteLine($"Next year you'll be {age}");
            Console.WriteLine("Let's build something great!\n");


            // Clean startup
            Startup.DataTypesExample();
            // Constants Example
            Startup.ConstantsExample();
            // String Operations Example
            Startup.StringOperationsExample();

            // Run conditions examples
            Conditions.ConditionsExample();
            Conditions.ShortHandIfElseExample();
            Conditions.ShortHandIfElseMultipleExample();

            // Run Switchapps
            Switchapp.SwitchDefault();
            Switchapp.SwitchDefault();

            // Run Loop
            LoopsWhile.LoopOne();
            LoopsWhile.LoopTwo();
            LoopsWhile.Loopthree();
            LoopsWhile.NestedLoop();
            LoopsWhile.LoopFour();

            // breake and continue
            Sbreak.CombineExample();
            Sbreak.CountExample();
            Sbreak.RunBreakExample();

            // arrays
            ArraysItem.ItemArrays();
            ArraysItem.WhilwQue();
            ArraysItem.PlantQue();
            ArraysItem.TwoDimensionalarray();

            // Methods
            Method.MethodExample();
            // Parameters and Arguments
            Parameter.MyMethods();

            Console.WriteLine("\n\nPress Enter to exit...");
            Console.ReadLine();
        }
    }
}