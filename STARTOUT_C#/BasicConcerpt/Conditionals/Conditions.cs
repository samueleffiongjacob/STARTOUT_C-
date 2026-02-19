using System;
using System.Collections.Generic;
using System.Text;

namespace STARTOUT_C_.BasicConcerpt.Conditionals
{
    class Conditions
    {
        public static void ConditionsExample()
        {
            /* 
             *  if (condition1)
                {
                  // block of code to be executed if condition1 is True
                } 
                else if (condition2) 
                {
                  // block of code to be executed if the condition1 is false and condition2 is True
                } 
                else
                {
                  // block of code to be executed if the condition1 is false and condition2 is False
                }
          */
            int time = 9;
            if (time < 10)
            {
                Console.WriteLine("Good morning.");
            }
            else if (time < 20)
            {
                Console.WriteLine("Good day.");
            }
            else
            {
                Console.WriteLine("Good evening.");
            }
        }

        public static void ShortHandIfElseExample()
        {
            /*
                * Short Hand If...Else (Ternary Operator)
                There is also a short-hand if else, which is known as the ternary operator because it 
                    consists of three operands. It can be used to replace multiple lines of code with a single
                    line. It is often used to replace simple if else statements:

                variable = (condition) ? expressionTrue : expressionFalse;
            */
            int time = 17;
            string result = (time < 18) ? "Good day." : "Good evening.";
            Console.WriteLine(result);
        }

        public static void ShortHandIfElseMultipleExample()
        {
            int time = 22;
            string result = (time < 10) ? "Good morning." :
                (time < 20) ? "Good day." : "Good evening.";
            Console.WriteLine(result);
        }

    }
}
