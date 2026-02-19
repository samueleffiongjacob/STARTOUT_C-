using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace STARTOUT_C_.BasicConcerpt.Loops
{
    class Sbreak
    {
        /*
         * C# Break
            You have already seen the break statement used in an earlier chapter of this tutorial. It was used to "jump out" of a switch statement.

            The break statement can also be used to jump out of a loop.

            This example jumps out of the loop when i is equal to 4:
         */

        static void BreakExample()
        {
            for (int i = 0; i < 10; i++)
            {
                if (i == 4)
                {
                    break;
                }
                Console.WriteLine(i);
            }
        }

        public static void RunBreakExample()
        {
            Console.WriteLine("=== Break Example ===\n");
            BreakExample();
        }

        /*C# Continue
        The continue statement breaks one iteration(in the loop), if a specified condition occurs, and continues with the next iteration in the loop.

        This example skips the value of 4:
        */

        static void ContinueExample()
        {
            for (int i = 0; i < 10; i++)
            {
                if (i == 4)
                {
                    continue;
                }
                Console.WriteLine(i);
            }
        }

        public static void CountExample()
        {
            Console.WriteLine("=== countinue Example ===\n");
            ContinueExample();
        }

        // You can also use break and continue in while loops:

        static void WhileExample()
        {
            int i = 0;
            while (i < 10)
            {
                Console.WriteLine(i);
                i++;
                if (i == 4)
                {
                    break;
                }
            }
        }
        // countinue

        static void Wkl()
        {
            int i = 0;
            while (i < 10)
            {
                if (i == 4)
                {
                    i++;
                    continue;
                }
                Console.WriteLine(i);
                i++;
            }
        }

        public static void CombineExample()
        {
            Console.WriteLine("=== countinue Example ===\n");
            Wkl();
            WhileExample();
        }
    }
}