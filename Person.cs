using System;


namespace ConsoleApp1
{ 
    internal class Person
    {
        public string Name;
        public int Age;

        // Default constructor
        public Person()
        {
            Name = "Unknown";
            Age = 0;
        }

        public void Display()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}");
        }
    }


}
