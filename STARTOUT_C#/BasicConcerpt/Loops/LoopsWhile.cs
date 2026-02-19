using System;
using System.Collections.Generic;
using System.Text;
//using static System.Runtime.InteropServices.JavaScript.JSType;

namespace STARTOUT_C_.BasicConcerpt.Loops
{
    class LoopsWhile
    {
        public static void LoopOne()
        {
            int i = 0;
            while (i < 5)
            {
                Console.WriteLine(i);
                i++;
            }
        }

        public static void LoopTwo()
        {
            /*
             * The Do/While Loop
             * The do/while loop is a variant of the while loop. This loop will execute the code block once, before checking if the condition is true, then it will repeat the loop as long as the condition is true.
              do
              {
                code block to be excuted
              }
               while (condition);

              The example below uses a do/while loop. The loop will always be executed at least once, even if the condition is false, because the code block is executed before the condition is tested:
             */

            int i = 0;
            do
            {
                Console.WriteLine(i);
                i++;
            }
            while (i < 5);
        }

        public static void Loopthree()
        {
            /*
             * When you know exactly how many times you want to loop through a block of code, use the for loop instead of a while loop:
             
                for (statement 1; statement2; statement3)
                {
                   code block to be xecuted  
                }

                Statement 1 is executed (one time) before the execution of the code block.
                Statement 2 defines the condition for executing the code block.

                Statement 3 is executed (every time) after the code block has been executed.

                The example below will print the numbers 0 to 4:
             */
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("print the numbers 0 to 4: \n" + i);
            }

            /*
            Example explained
            Statement 1 sets a variable before the loop starts (int i = 0).

            Statement 2 defines the condition for the loop to run (i must be less than 5). If the condition is true, the loop will start over again, if it is false, the loop will end.

            Statement 3 increases a value (i++) each time the code block in the loop has been executed.
            Another Example
            This example will only print even values between 0 and 10:
            */

            for (int j = 0; j <= 10; j = j + 2)
            {
                Console.WriteLine("this print even number in 0-10 \n" + j);
            }
        }

        public static void NestedLoop()
        {
            /*
             * Nested Loops
             * It is also possible to place a loop inside another loop. This is called a nested loop.

               The "inner loop" will be executed one time for each iteration of the "outer loop":
             */

            // outer loop
            for (int i = 0; i < 5; ++i)
            {
                Console.WriteLine("outer: \n" + i); // Excutes 2 times

                // Inner loop
                for (int j = 0; j <= 10; j++)
                {
                    Console.WriteLine("Inner : \n" + j);
                }


            }
        }

        // creating private method to call in main method
        static void ForLoop()
        {
            /*
            The foreach Loop
            There is also a foreach loop, which is used exclusively to loop through elements in an array(or other data sets):

            foreach (type variableName in arrayName) 
            {
              // code block to be executed
            }
            */

            string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };

            foreach (string i in cars)
            {
                Console.WriteLine(i);
            }
        }

        // let use the private method in main method
        public static void LoopFour()
        {
            ForLoop();
        }
    }
}