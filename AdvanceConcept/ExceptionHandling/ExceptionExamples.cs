namespace AdvanceConcept.ExceptionHandling
{
    public static class ExceptionExamples
    {
        public static void RunExamples()
        {
            Console.WriteLine("⚠️ Exception Handling Examples...\n");

            // Try-Catch
            Console.WriteLine("1. Basic Try-Catch:");
            try
            {
                int result = Divide(10, 0);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine($"❌ Error: {ex.Message}");
            }

            Console.WriteLine();

            // Multiple Catch Blocks
            Console.WriteLine("2. Multiple Catch Blocks:");
            try
            {
                string? text = null;
                int length = text!.Length; // Will throw NullReferenceException
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine($"❌ Null Reference Error: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"❌ General Error: {ex.Message}");
            }

            Console.WriteLine();

            // Finally Block
            Console.WriteLine("3. Try-Catch-Finally:");
            try
            {
                Console.WriteLine("  Executing try block...");
                throw new InvalidOperationException("Sample exception");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"  ❌ Caught: {ex.Message}");
            }
            finally
            {
                Console.WriteLine("  ✅ Finally block always executes!");
            }

            Console.WriteLine();

            // Custom Exception
            Console.WriteLine("4. Custom Exception:");
            try
            {
                ValidateAge(-5);
            }
            catch (InvalidAgeException ex)
            {
                Console.WriteLine($"❌ {ex.Message}");
            }
        }

        private static int Divide(int a, int b)
        {
            return a / b;
        }

        private static void ValidateAge(int age)
        {
            if (age < 0)
            {
                throw new InvalidAgeException("Age cannot be negative!");
            }
        }
    }

    // Custom Exception
    public class InvalidAgeException : Exception
    {
        public InvalidAgeException(string message) : base(message) { }
    }
}