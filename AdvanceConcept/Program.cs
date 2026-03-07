using AdvanceConcept.OOP;
using AdvanceConcept.Collections;
using AdvanceConcept.LINQ;
using AdvanceConcept.AsyncProgramming;
using AdvanceConcept.ExceptionHandling;
using AdvanceConcept.FileIO;
using System;

namespace AdvanceConcept
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("╔════════════════════════════════════════════╗");
            Console.WriteLine("║   Welcome to Advanced C# Concepts!         ║");
            Console.WriteLine("╔════════════════════════════════════════════╗\n");

            // User Input
            Console.WriteLine("👋 What's your name? ");
            string name = Console.ReadLine() ?? "Learner";
            Console.WriteLine($"Hello {name}! Ready to level up your C# skills?\n");

            Console.WriteLine("📚 Advanced Topics Covered:");
            Console.WriteLine("━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━\n");

            try
            {
                // 0 Object -Oriented Programming class
                Console.WriteLine("🔹 0. Object-Oriented Programming (OOP) Class");
                OopBegining.RunBasicExample();
                OopBegining.RunAdvancedExample();
                Cars.CarsExample();
                Console.WriteLine("━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━\n");

                // 0i Enscapulation
                Console.WriteLine("🔹 0i. Encapsulation in OOP");
                Console.WriteLine("━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━");
                var encapsulation = new Encapsulation();
                encapsulation.RunExamplesEncap();
                Console.WriteLine("==================================");
                var encapsulation2 = new EncapsulationExample();
                encapsulation2.RunEncapsulationExample();
                Console.WriteLine("==============================");

                // 0ii Polymorphism note all ways use below to call instance method if u are not using static method
                Console.WriteLine("🔹 0ii. Polymorphism");
                Console.WriteLine("====================");
                var polymorphism = new Polymorphism();
                polymorphism.RunPolymorphismExample();
                Console.WriteLine("========== Polymopysim2");
                var polymorphism2 = new Polymorphism2();
                polymorphism2.RunPolymorphismExample();
                Console.WriteLine("━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━\n");

                // 0ii Abstraction
                Console.WriteLine("🔹 0iii. Abstraction");
                Console.WriteLine("====================");
                AbstractandInterface.RunAbstractExample();
                Console.WriteLine("━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━\n");

                // 0iv Interface
                Console.WriteLine("🔹 0iv. Interface");
                Console.WriteLine("====================");
                InterfaceExample.RunInterfaceExample();
                Console.WriteLine("━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━\n Multiple Interface");
                MultipleInterfaceExample.RunMultipleInterfaceExample();
                Console.WriteLine("━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━\n");

                // 0v Enum and Struct
                Console.WriteLine("🔹 0v. Enum and Struct");
                Console.WriteLine("====================");
                EnumExample.RunEnumExample();
                Console.WriteLine("==================================");

                // 1. Object-Oriented Programming
                Console.WriteLine("🔹 1. Object-Oriented Programming (OOP)");
                Console.WriteLine("━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━");
                OOPExamples.RunExamples();
                Console.WriteLine();

                // 2. Collections & Generics
                Console.WriteLine("🔹 2. Collections & Generics");
                Console.WriteLine("━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━");
                CollectionsExamples.RunExamples();
                Console.WriteLine();

                // 3. LINQ (Language Integrated Query)
                Console.WriteLine("🔹 3. LINQ - Language Integrated Query");
                Console.WriteLine("━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━");
                LINQExamples.RunExamples();
                Console.WriteLine();

                // 4. Async/Await Programming
                Console.WriteLine("🔹 4. Async/Await Programming");
                Console.WriteLine("━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━");
                await AsyncExamples.RunExamplesAsync();
                Console.WriteLine();

                // 5. Exception Handling
                Console.WriteLine("🔹 5. Exception Handling");
                Console.WriteLine("━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━");
                ExceptionExamples.RunExamples();
                Console.WriteLine();

                // 6. File I/O Operations
                Console.WriteLine("🔹 6. File I/O Operations");
                Console.WriteLine("━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━");
                FileIOExamples.RunExamples();
                Console.WriteLine();

                Console.WriteLine("\n✅ Congratulations! You've completed all advanced examples!");
                Console.WriteLine($"🎓 Keep practicing, {name}! You're doing great!\n");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"\n❌ An error occurred: {ex.Message}");
                Console.WriteLine($"📝 Stack Trace: {ex.StackTrace}");
            }

            Console.WriteLine("\n━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━");
            Console.WriteLine("Press Enter to exit...");
            Console.ReadLine();
        }
    }
}