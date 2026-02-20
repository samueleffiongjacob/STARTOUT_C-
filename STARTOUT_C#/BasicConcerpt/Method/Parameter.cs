using System;
using System.Collections.Generic;
using System.Text;

namespace STARTOUT_C_.BasicConcerpt.Method
{
    class Parameter
    {
        static void MyMethod(string fname)
        {
            /*
             * Parameters and Arguments
               Information can be passed to methods as parameter. Parameters act as variables inside the method.

               They are specified after the method name, inside the parentheses. You can add as many parameters as you want, just separate them with a comma.

               The following example has a method that takes a string called fname as parameter. When the method is called, we pass along a first name, which is used inside the method to print the full name:
            */
            Console.WriteLine(fname + " Refsnes");

            /*
             * When a parameter is passed to the method, it is called an argument. So, from the example above: fname is a parameter, while Liam, Jenny and Anja are arguments.
            */
        }

        static void MultipleParameters(string fname, int age)
        {
            /* 
             * Multiple Parameters
             * * You can also have more than one parameter. Just separate the parameters with a comma.*/
            Console.WriteLine(fname + " is " + age);
        }

        public static void MyMethods()
        {
            MyMethod("Liam");
            MyMethod("Jenny");
            MyMethod("Anja");

            Console.WriteLine("Multiple Parameters \n");
            MultipleParameters("Samuel Effiong", 25);
            MultipleParameters("Effiong Jacob", 20);
            MultipleParameters("Samuel Effiong Jacob", 15);
        }
    }
}
