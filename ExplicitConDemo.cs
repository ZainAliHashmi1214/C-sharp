using System;

namespace ConsoleApp1
{
    class ExplicitConDemo
    {
        public ExplicitConDemo ()
        {
            Console.WriteLine("Constructer is called."); 
        }
        static void Main ()
        {
            ExplicitConDemo obj1 = new ExplicitConDemo ();
            ExplicitConDemo obj2 = new ExplicitConDemo();
            ExplicitConDemo obj3 = new ExplicitConDemo();
            Console.ReadLine();
        }
    }
    
}
