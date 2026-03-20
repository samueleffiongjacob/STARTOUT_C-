namespace AdvanceConcept.OOP
{
    /*
     * Abstract Classes and Methods
        Data abstraction is the process of hiding certain details and showing only essential information to the user.
        Abstraction can be achieved with either abstract classes or interfaces (which you will learn more about in the next chapter).

        The abstract keyword is used for classes and methods:

        Abstract class: is a restricted class that cannot be used to create objects (to access it, it must be inherited from another class).

        Abstract method: can only be used in an abstract class, and it does not have a body. The body is provided by the derived class (inherited from).
        An abstract class can have both abstract and regular methods:
    */
    abstract class Animals1
    {
        public abstract void animalSound(); // Abstract method (does not have a body)
        public void sleep() // Regular method
        {
            Console.WriteLine("Zzz");
        }
    }

    // Derived class (inherited from Animals1)
    class Pig1 : Animals1
    {
        public override void animalSound()
        {
            // The body of animalSound() is provided here
            Console.WriteLine("The pig says: wee wee");
        }
    }

    public static class AbstractandInterface
    {
        public static void RunAbstractExample()
        {
            Pig1 myPig = new Pig1(); // Create a Pig object
            myPig.animalSound(); // Call the abstract method
            myPig.sleep();// Call the regular method
        }
    }

    /*
     * Interfaces
        Another way to achieve abstraction in C#, is with interfaces.
        An interface is a completely "abstract class", which can only contain abstract methods and properties (with empty bodies):
    */

    // interface
    interface IAnimals
    {
        void animalSound(); // interface method (does not have a body)
        //void run(); // interface method (does not have a body)
    }

    // Pig ImplementS the IAnimal interface
    class Pig3 : IAnimals
    {
        public void animalSound()
        {
            Console.WriteLine("The pig says: wee wee");
        }
    }

    public static class InterfaceExample
    {
        public static void RunInterfaceExample()
        {
            Pig3 myPig = new Pig3(); // Create a Pig object
            myPig.animalSound(); // Call the interface method
        }
    }

    // multiple interfaces
    interface IFirstInterface
    {
        void myMethod(); // interface method (does not have a body)
    }

    interface ISecondInterface
    {
        void myOtherMethod(); // interface method (does not have a body)
    }

    // Implement multiple interfaces
    class DemoClass : IFirstInterface, ISecondInterface
    {
        public void myMethod()
        {
            Console.WriteLine("Some text..");
        }
        public void myOtherMethod()
        {
            Console.WriteLine("Some other text...");
        }
    }

    public static class MultipleInterfaceExample
    {
        public static void RunMultipleInterfaceExample()
        {
            DemoClass demo = new DemoClass();
            demo.myMethod();
            demo.myOtherMethod();
        }
    }

}
