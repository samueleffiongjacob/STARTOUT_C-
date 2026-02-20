namespace AdvanceConcept.LINQ
{
    public static class LINQExamples
    {
        public static void RunExamples()
        {
            Console.WriteLine("🔍 LINQ Query Examples...\n");

            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            // Where - Filter
            var evenNumbers = numbers.Where(n => n % 2 == 0);
            Console.WriteLine("Even Numbers:");
            Console.WriteLine($"  {string.Join(", ", evenNumbers)}");

            // Select - Transform
            var squares = numbers.Select(n => n * n);
            Console.WriteLine("\nSquares:");
            Console.WriteLine($"  {string.Join(", ", squares)}");

            // OrderBy
            var descendingNumbers = numbers.OrderByDescending(n => n);
            Console.WriteLine("\nDescending Order:");
            Console.WriteLine($"  {string.Join(", ", descendingNumbers)}");

            // Any, All
            bool hasNumberGreaterThan5 = numbers.Any(n => n > 5);
            bool allPositive = numbers.All(n => n > 0);
            Console.WriteLine($"\nHas number > 5? {hasNumberGreaterThan5}");
            Console.WriteLine($"All positive? {allPositive}");

            // Aggregate
            int sum = numbers.Sum();
            double average = numbers.Average();
            int max = numbers.Max();
            int min = numbers.Min();

            Console.WriteLine($"\nSum: {sum}");
            Console.WriteLine($"Average: {average}");
            Console.WriteLine($"Max: {max}");
            Console.WriteLine($"Min: {min}");

            // Complex objects with LINQ
            Console.WriteLine("\n📊 Working with Objects:");
            
            var people = new List<Person>
            {
                new Person("Alice", 25, "Developer"),
                new Person("Bob", 30, "Designer"),
                new Person("Charlie", 28, "Developer"),
                new Person("David", 35, "Manager")
            };

            var developers = people.Where(p => p.Role == "Developer")
                                   .Select(p => p.Name);
            
            Console.WriteLine("Developers:");
            foreach (var dev in developers)
            {
                Console.WriteLine($"  👨‍💻 {dev}");
            }

            var averageAge = people.Average(p => p.Age);
            Console.WriteLine($"\nAverage Age: {averageAge:F1} years");
        }
    }

    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Role { get; set; }

        public Person(string name, int age, string role)
        {
            Name = name;
            Age = age;
            Role = role;
        }
    }
}