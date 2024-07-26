using System;
using System.Threading;

class Program
{
    static void Main()
    {
        
        Thread thread1 = new Thread(PrintNumbers);
        thread1.Name = "Thread 1";

        
        Thread thread2 = new Thread(PrintNumbers);
        thread2.Name = "Thread 2";

        thread1.Start();
        thread2.Start();

        
        thread1.Join();
        thread2.Join();

        Console.WriteLine("All threads have completed their work.");
    }


    static void PrintNumbers()
    {
        for (int i = 1; i <= 5; i++)
        {
            Console.WriteLine($"{Thread.CurrentThread.Name} prints {i}");
            Thread.Sleep(100); 
        }
    }
}
