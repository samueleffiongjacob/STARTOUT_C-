using System;
using System.Collections.Generic;
using System.Text;

namespace AdvanceConcept.OOP
{
    class Encapsulation
    {
        // C# Properties (Get and Set)
        /*Properties and Encapsulation
           Before we start to explain properties, you should have a basic understanding of "Encapsulation".

           The meaning of Encapsulation, is to make sure that "sensitive" data is hidden from users. To achieve this, you must:

           declare fields/variables as private
           provide public get and set methods, through properties, to access and update the value of a private field
        */

        private String names; // private field
        public string Names // public property
        {
            get { return names; } // get method
            set { names = value; } // set method
        }

        public void RunExamplesEncap()
        {
            Encapsulation example = new Encapsulation();
            example.Names = "Samuel Effiong"; // using the set method
            Console.WriteLine($"Name: {example.Names}"); // using the get method
        }
    }

    class EncapsulationExample
    {
        //private int age; // private field
        //public int Age // public property
        //{
        //    get { return age; } // get method
        //    set 
        //    { 
        //        if (value < 0) // validation in set method
        //        {
        //            Console.WriteLine("Age cannot be negative.");
        //        }
        //        else
        //        {
        //            age = value; // set method
        //        }
        //    }
        //}

        public int Age { get; set; } // auto-implemented property
        public void RunEncapsulationExample()
        {
            EncapsulationExample example = new EncapsulationExample();
            example.Age = 25; // valid age
            Console.WriteLine($"Age: {example.Age}"); // using the get method
            example.Age = -5; // invalid age, will trigger validation
            Console.WriteLine($"Age after invalid input: {example.Age}"); // age remains unchanged
        }
    }
}
