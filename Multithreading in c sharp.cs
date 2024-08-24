using System;
using System.Threading;

class Program
{
    
    static void PrintNumbers()
    {
        for (int i = 1; i <= 5; i++)
        {
            Console.WriteLine($"PrintNumbers: {i}");
            Thread.Sleep(1000);         }
    }

    
    static void PrintLetters()
    {
        for (char c = 'A'; c <= 'E'; c++)
        {
            Console.WriteLine($"PrintLetters: {c}");
            Thread.Sleep(1000); 
        }
    }

    static void Main(string[] args)
    {
        
        Thread thread1 = new Thread(PrintNumbers);

        
        Thread thread2 = new Thread(PrintLetters);

        
        thread1.Start();
        thread2.Start();

               thread1.Join();
        thread2.Join();

        Console.WriteLine("Both threads have completed their work.");
    }
}

