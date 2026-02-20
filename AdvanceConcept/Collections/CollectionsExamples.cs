using System.Collections.Generic;

namespace AdvanceConcept.Collections
{
    public static class CollectionsExamples
    {
        public static void RunExamples()
        {
            Console.WriteLine("📚 Working with Collections...\n");

            // List<T>
            Console.WriteLine("List Example:");
            List<string> fruits = new List<string> { "Apple", "Banana", "Orange" };
            fruits.Add("Mango");
            fruits.Add("Grapes");

            Console.WriteLine("Fruits in the list:");
            foreach (var fruit in fruits)
            {
                Console.WriteLine($"  🍎 {fruit}");
            }

            Console.WriteLine();

            // Dictionary<TKey, TValue>
            Console.WriteLine("Dictionary Example:");
            Dictionary<string, int> studentGrades = new Dictionary<string, int>
            {
                { "Alice", 95 },
                { "Bob", 87 },
                { "Charlie", 92 }
            };

            studentGrades.Add("David", 88);

            Console.WriteLine("Student Grades:");
            foreach (var student in studentGrades)
            {
                Console.WriteLine($"  📝 {student.Key}: {student.Value}");
            }

            Console.WriteLine();

            // Queue<T>
            Console.WriteLine("Queue Example (FIFO - First In, First Out):");
            Queue<string> customers = new Queue<string>();
            customers.Enqueue("Customer 1");
            customers.Enqueue("Customer 2");
            customers.Enqueue("Customer 3");

            Console.WriteLine("Serving customers:");
            while (customers.Count > 0)
            {
                string customer = customers.Dequeue();
                Console.WriteLine($"  👤 Serving: {customer}");
            }

            Console.WriteLine();

            // Stack<T>
            Console.WriteLine("Stack Example (LIFO - Last In, First Out):");
            Stack<string> plates = new Stack<string>();
            plates.Push("Plate 1");
            plates.Push("Plate 2");
            plates.Push("Plate 3");

            Console.WriteLine("Removing plates:");
            while (plates.Count > 0)
            {
                string plate = plates.Pop();
                Console.WriteLine($"  🍽️ Removed: {plate}");
            }
        }
    }
}