using System;


namespace ConsoleApp1
{
    class CopyConDemo
    {
        int x;
        public CopyConDemo(int i)
        {
            x = i;
        }
        public CopyConDemo (CopyConDemo obj)
        {
            x = obj.x;
        }
        public void Display()
        {
            Console.WriteLine("Value of x is:" + x);
        }
        static void Main ()
        {
            CopyConDemo demo = new CopyConDemo(10);
            demo.Display();
            CopyConDemo demo2 = new CopyConDemo(demo);
            demo2.Display();

            Console.ReadLine();
        }
    }

}
