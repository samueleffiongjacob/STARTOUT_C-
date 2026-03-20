namespace AdvanceConcept.OOP
{
    public class OopBegining
    {
        /*
         * C# - What is OOP?
            OOP stands for Object-Oriented Programming.

            Procedural programming is about writing procedures or methods that perform operations on the data, 
            while object-oriented programming is about creating objects that contain both data and methods.

            Object-oriented programming has several advantages over procedural programming:

            OOP is faster and easier to execute
            OOP provides a clear structure for the programs
            OOP helps to keep the C# code DRY "Don't Repeat Yourself", and makes the code easier to maintain, modify and debug
            OOP makes it possible to create full reusable applications with less code and shorter development time
            Constructors
            A constructor is a special method that is used to initialize objects. The advantage of a constructor, is that it is called when an object of a class is created. It can be used to set initial values for fields:
        */

        public static void RunBasicExample()
        {
            // Create an object of the SimpleCar class
            SimpleCar myCar = new SimpleCar();
            myCar.color = "red";
            myCar.model = "Mustang";
            
            // Access properties
            Console.WriteLine($"Car Color: {myCar.color}");
            Console.WriteLine($"Car Model: {myCar.model}");
            
            // Call method
            myCar.Honk();
        }
        
        public static void RunAdvancedExample()
        {
            // Using the Car class from OOPExamples
            Car myCar = new Car("Tesla", "Model 3", 2024);
            Console.WriteLine("display car info:");
            myCar.DisplayInfo();
            Console.WriteLine("start the car:");
            myCar.Start();
        }
    }
    
    // Simple Car class for beginners
    public class SimpleCar
    {
        public string? color;
        public string? model;
                
        public void Honk()
        {
            Console.WriteLine("=========🎺 Beep beep!============");
        }
    }

    public class Cars
    {
        private string color = "red";
        private static void RunBasicCars()
        {
            Cars myObj = new Cars();
            Console.WriteLine($"Car Color: {myObj.color}");
        }

        public static void CarsExample()
        {
            Console.WriteLine("🚗 Running basic Cars example...");
            RunBasicCars();
        }
    }

    // C# Properties (Get and Set)
}
