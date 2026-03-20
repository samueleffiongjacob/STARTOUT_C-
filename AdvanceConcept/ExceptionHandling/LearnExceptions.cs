namespace AdvanceConcept.ExceptionHandling
{

    // Exceptions - Try..Catch
    /*
     * When executing C# code, different errors can occur: coding errors made by the programmer, errors due to wrong input, or other unforeseeable things.
     * When an error occurs, C# will normally stop and generate an error message. The technical term for this is: C# will throw an exception (throw an error).
     * C# try and catch
     * The try statement allows you to define a block of code to be tested for errors while it is being executed.
     * The catch statement allows you to define a block of code to be executed, if an error occurs in the try block.
     * The try and catch keywords come in pairs:
     * try
     * {
     *      // block of code to try
     * }
     * catch (Exception e)
     * {
     *      // Block of code to handle errors
     * }
    */
    class LearnExceptions
    {
        static void RunExceptionExample()
        {
            try
            {
                int[] myNumbers = { 1, 2, 3 };
                Console.WriteLine(myNumbers[10]);
            }
            catch (Exception e)
            {
                Console.WriteLine($"Something went wrong. Samuel: {e.Message}");
            }
        }

        /*
         * Finally
         * The finally statement lets you execute code, after try...catch, regardless of the result
        */

        static void RunFinallyExample()
        {
                try
                {
                    int[] myNumbers = { 1, 2, 3 };
                    Console.WriteLine(myNumbers[10]);
                }
                catch (Exception e)
                {
                    Console.WriteLine($"Something went wrong. Samuel: {e.Message}");
                }
                finally
                {
                    Console.WriteLine("The 'try catch' is finished.");
                }
        }

        static void checkAge(int age)
        { 
            if (age < 18)
            {
                throw new ArithmeticException("Access denied - You must be at least 18 years old.");
            }
            else
            {
                Console.WriteLine("Access granted - You are old enough!");
            }
        }
        
        public static void RunTheExceptionExample()
        { 
            Console.WriteLine("Running the exception example...");
            RunExceptionExample();
            Console.WriteLine("Finished running the exception example.");
            RunFinallyExample();
            Console.WriteLine("Checking ArithmeticException");
            checkAge(20); // check to know why it stops at 15
            Console.WriteLine("ended the exception example...");
        }
    }

    
}
