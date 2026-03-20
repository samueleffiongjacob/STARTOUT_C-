namespace AdvanceConcept.OOP
{
    /*
     * C# Enums
        An enum is a special "class" that represents a group of constants (unchangeable/read-only variables).

        To create an enum, use the enum     keyword (instead of class or interface), and separate the enum items with a comma:
    */

    enum Level
    { 
        Low,
        Medium,
        High
    }

    enum Month
    {
        January, // 0
        February,// 1
        March,// 2
        April,// 3
        May,// 4
        June,// 5
        July,// 6
        August,// 7
        September,// 8
        October,// 9
        November,// 10
        December// 11
    }

    // we can also assign specific integer values to the enum members, if we want to start from a different number or have custom values:
    enum Status
    {
        Pending = 1,
        InProgress = 2,
        Completed = 3,
        Failed = 4
    }

    public static class EnumExample
    {
        public static void RunEnumExample()
        {
              Level myVar = Level.Medium;
              Console.WriteLine($"My level is: {myVar}");

            Console.WriteLine("======================= accessing enum values =======================");
            int lowValue = (int) Month.December; // Accessing the underlying integer value of the enum member
            Console.WriteLine($"The integer value of Month.December is: {lowValue}");

            Console.WriteLine("======================= iterating over enum values =======================");
            foreach (Month month in System.Enum.GetValues(typeof(Month)))
            {
                Console.WriteLine($"Month: {month}, Value: {(int)month}");
            }
            Console.WriteLine("======================= parsing string to enum =======================");
            Console.WriteLine($"Parsing 'High' to Level enum: {System.Enum.Parse(typeof(Level), "High")}");
            Console.WriteLine($"Parsing 'InProgress' to Status enum: {System.Enum.Parse(typeof(Status), "InProgress")}");
            Console.WriteLine($"Parsing 'December' to Month enum: {System.Enum.Parse(typeof(Month), "December")}");
            
            int StatusValue = (int) Status.Completed;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"The integer value of Status.Completed is: {StatusValue}");
            // terminal color
            Console.ForegroundColor = ConsoleColor.Green;
        }
    }
}
