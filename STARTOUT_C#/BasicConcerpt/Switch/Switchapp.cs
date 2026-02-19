using System;
using System.Collections.Generic;
using System.Text;
//using System.Text.RegularExpressions;
//using static System.Net.Mime.MediaTypeNames;

namespace STARTOUT_C_.BasicConcerpt.Switch
{
    class Switchapp
    {
        public static void SwitchSocket()
        {
            /* 
                   Switch(expression
                   {
                       case x: :
                          code block
                           break;
                       case y:
                           code block
                           break;
                       default:
                           code block
                           break;
                   }

                   This is how it works:

                   The switch expression is evaluated once
                   The value of the expression is compared with the values of each case
                   If there is a match, the associated block of code is executed
                   The break and default keywords will be described later in this chapter
                   The example below uses the weekday number to calculate the weekday name:
            */
            int day = 4;
            switch (day)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("\nToday is Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;
                case 7:
                    Console.WriteLine("Sunday");
                    break;
                default:
                    Console.WriteLine("Invalid day");
                    break;
            }
        }

        /*
           The break Keyword
           When C# reaches a break keyword, it breaks out of the switch block.

           This will stop the execution of more code and case testing inside the block.

           When a match is found, and the job is done, it's time for a break. There is no need for more testing.
       */

        /*
        The default Keyword
        The default keyword is optional and specifies some code to run if there is no case match:
        */
        public static void SwitchDefault()
        {
            int days = 4;
            switch (days)
            {
                case 6:
                    Console.WriteLine("Today is Saturday.");
                    break;
                case 7:
                    Console.WriteLine("Today is Sunday.");
                    break;
                default:
                    Console.WriteLine("Looking forward to the Weekend.");
                    break;
            }
        }
    }
}