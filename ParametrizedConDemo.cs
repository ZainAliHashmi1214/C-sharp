using System;

namespace ConsoleApp1
{
     class ParametrizedConDemo
    {
        int x;
         public ParametrizedConDemo(int i)
            
        {
            x = i;
            Console.WriteLine("Parametrized Constructer is called:" + i);
        }
        public void Display ()
        {
            Console.WriteLine("value of x is:" + x);
        }
        static void Main ()
        {
            ParametrizedConDemo demo = new ParametrizedConDemo(10);
            ParametrizedConDemo demo2 = new ParametrizedConDemo(20);

            demo.Display();
            demo2.Display();
            Console.ReadLine();
        }
    }
}
