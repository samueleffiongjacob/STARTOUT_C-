using STARTOUT_C_.BasicConcerpt.Arrays;
using STARTOUT_C_.BasicConcerpt.Conditionals;
using STARTOUT_C_.BasicConcerpt.Loops;
using STARTOUT_C_.BasicConcerpt.Startup;
using STARTOUT_C_.BasicConcerpt.Switch;
using STARTOUT_C_.BasicConcerpt.Method;
namespace STARTOUT_C_
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Clear();
                Console.WriteLine("Welcome to C# Programming! \n");

                // User Input Example

                Console.WriteLine("What's your name? ");
                string? name = Console.ReadLine();
                Console.WriteLine("What's your age? ");
                int age = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine($"Hello {name}!");
                Console.WriteLine($"You're learning C# at age: {age}");
                age += 1;
                Console.WriteLine($"Next year you'll be {age}");
                Console.WriteLine("Let's build something great!\n");

                Clear();
                // Clean startup
                Startup.DataTypesExample();
                
                Clear();
                // Constants Example
                Startup.ConstantsExample();
                
                Clear();
                // String Operations Example
                Startup.StringOperationsExample();

                Clear();
                // Run conditions examples
                Conditions.ConditionsExample();
                
                Clear();
                Conditions.ShortHandIfElseExample();
                
                Clear();
                Conditions.ShortHandIfElseMultipleExample();

                Clear();
                // Run Switchapps
                Switchapp.SwitchDefault();
                
                Clear();
                Switchapp.SwitchDefault();

                Clear();
                // Run Loop
                LoopsWhile.LoopOne();
                
                Clear();
                LoopsWhile.LoopTwo();
                
                Clear();
                LoopsWhile.Loopthree();
                
                Clear();
                LoopsWhile.NestedLoop();
                
                Clear();
                LoopsWhile.LoopFour();

                Clear();
                // breake and continue
                Sbreak.CombineExample();
                
                Clear();
                Sbreak.CountExample();
                
                Clear();
                Sbreak.RunBreakExample();

                Clear();
                // arrays
                ArraysItem.ItemArrays();
                
                Clear();
                ArraysItem.WhilwQue();
                
                Clear();
                ArraysItem.PlantQue();
                
                Clear();
                ArraysItem.TwoDimensionalarray();

                Clear();
                // Methods
                Method.MethodExample();
                
                Clear();
                // Parameters and Arguments
                Parameter.MyMethods();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"\nAn error occurred: {ex.Message}");
            }

            Console.WriteLine("\n\nPress Enter to exit...");
            Console.ReadLine();
        }

        public static void Clear()
        { 
            Console.WriteLine("\nPress Enter to clear the screen and continue...");
            Console.ReadLine();
            Console.Clear();
        }
    }
}