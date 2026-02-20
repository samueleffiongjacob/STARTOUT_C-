namespace AdvanceConcept.OOP
{
    public static class OOPExamples
    {
        public static void RunExamples()
        {
            Console.WriteLine("📦 Creating objects and demonstrating inheritance...\n");

            // Classes and Objects
            var car = new Car("Tesla", "Model 3", 2024);
            car.DisplayInfo();
            car.Start();

            Console.WriteLine();

            // Inheritance
            var electricCar = new ElectricCar("Tesla", "Model S", 2024, 100);
            electricCar.DisplayInfo();
            electricCar.Charge();

            Console.WriteLine();

            // Polymorphism
            Vehicle vehicle1 = new Car("Toyota", "Camry", 2023);
            Vehicle vehicle2 = new ElectricCar("Nissan", "Leaf", 2023, 60);
            
            vehicle1.Start();
            vehicle2.Start();
        }
    }

    // Base class
    public abstract class Vehicle
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }

        public Vehicle(string brand, string model, int year)
        {
            Brand = brand;
            Model = model;
            Year = year;
        }

        public abstract void Start();

        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Vehicle: {Year} {Brand} {Model}");
        }
    }

    // Derived class
    public class Car : Vehicle
    {
        public Car(string brand, string model, int year) 
            : base(brand, model, year) { }

        public override void Start()
        {
            Console.WriteLine($"🚗 {Brand} {Model} engine started!");
        }
    }

    // Another derived class
    public class ElectricCar : Vehicle
    {
        public int BatteryLevel { get; set; }

        public ElectricCar(string brand, string model, int year, int batteryLevel) 
            : base(brand, model, year)
        {
            BatteryLevel = batteryLevel;
        }

        public override void Start()
        {
            Console.WriteLine($"⚡ {Brand} {Model} electric motor started! Battery: {BatteryLevel}%");
        }

        public void Charge()
        {
            Console.WriteLine($"🔌 Charging {Brand} {Model}...");
            BatteryLevel = 100;
            Console.WriteLine($"✅ Fully charged! Battery: {BatteryLevel}%");
        }
    }
}