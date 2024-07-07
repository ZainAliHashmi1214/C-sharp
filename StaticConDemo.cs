using System;

namespace ConsoleApp1
{
    class StaticConDemo
    {
    static StaticConDemo()
        {
            Console.WriteLine("Static Constructer is executed.");
        }
        static void Main() 
        { 
            Console.WriteLine("Main Method is executed.");
        }
    }
}
