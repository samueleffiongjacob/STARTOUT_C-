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

        static void DefaultParameter(string country = "Norway")
        {
            /*
             * Default Parameter Value
             * * You can also use default parameter values, by using the equals sign (=).. This way, when you call a method without passing an argument, the default value will be used.
             */
            Console.WriteLine(country);
            /*
             * A parameter with a default value, is often known as an "optional parameter". From the example above, country is an optional parameter and "Norway" is the default value.
            */
        }

        static int MethodMy(int x)
        {

            /*
             * Return Values
             * In the previous excerices, we used the void keyword in all examples, which indicates that the method should not return a value.

               If you want the method to return a value, you can use a primitive data type (such as int or double) instead of void, and use the return keyword inside the method:
            */
            return x + 5;
        }

        // returns the sum of a method's two parameters:
        static int MethodMy1(int x, int y)
        {
            return x + y;
        }

        // store the return value of a method in a variable:
        static int MethodMy2(int x, int y)
        {
            return x + y;
        }

        //Named Arguments
        static void NamedArguments(string child1, string child2, string child3,int age)
        {
            /*
             * Named Arguments
                It is also possible to send arguments with the key: value syntax.

                That way, the order of the arguments does not matter:
            */
            Console.WriteLine("The youngest child is: " + child3 + " is " + age);
        }

        /*Method Overloading
         * With method overloading, multiple methods can have the same name with different parameters:
         * int MyMethod(int x)
         * float MyMethod(float x)
         * double MyMethod(double x, double y)
         * Consider the following example, which has two methods that add numbers of different types:
        */

        static int PlusMethodInt(int x, int y)
        {
            return x + y;
        }

        static double PlusMethodDouble(double x, double y)
        {
                return x + y;
        }

        /*
         * Instead of defining two methods that should do the same thing, it is better to overload one.
         * In the example below, we overload the PlusMethod method to work for both int and double:
        */

        static int PlusMethod(int x, int y)
        {
            return x + y;
        }

        static double PlusMethod(double x, double y)
        {
            return x + y;
        }

        /*
         * Note: Multiple methods can have the same name as long as the number and/or type of parameters are different.
        */

        public static void MyMethods()
        {
            MyMethod("Liam");
            MyMethod("Jenny");
            MyMethod("Anja");

            Console.WriteLine("Multiple Parameters \n");
            MultipleParameters("Samuel Effiong", 25);
            MultipleParameters("Effiong Jacob", 20);
            MultipleParameters("Samuel Effiong Jacob", 15);

            Console.WriteLine("Default Parameter Value \n");
            DefaultParameter("Nigeria");
            DefaultParameter("germany");
            DefaultParameter();
            DefaultParameter("usa");

            // Return Values
            Console.WriteLine("Return Values \n");
            Console.WriteLine(MethodMy(3));

            // returns the sum of a method's two parameters:
            Console.WriteLine("return 2 parameter \n");
            Console.WriteLine(MethodMy1(3, 4));

            // store the return value of a method in a variable:
            Console.WriteLine("store the return value of a method in a variable \n");
            int result = MethodMy2(5, 6);
            Console.WriteLine(result);

            //Named Arguments
            Console.WriteLine("Named Arguments \n");
            NamedArguments(child3: "Samuel", child1: "Effiong", child2: "Jacob", age: 20);

            // Method Overloading
            Console.WriteLine("Method Overloading \n");
            int myNum1 = PlusMethodInt(8, 5);
            double myNum2 = PlusMethodDouble(4.3, 6.26);
            Console.WriteLine("Int: " + myNum1);
            Console.WriteLine("Double: " + myNum2);

            // Method Overloading with same name
            Console.WriteLine("Method Overloading with same name \n");
            int myNum3 = PlusMethod(8, 5);
            double myNum4 = PlusMethod(4.3, 6.26);
            Console.WriteLine("Int: " + myNum3);
            Console.WriteLine("Double: " + myNum4);
        }
    }
}
