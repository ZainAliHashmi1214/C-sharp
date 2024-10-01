


// Multithreding in c sharp
//using System;
//using System.Threading;

//public class MultithreadingExample
//{
//    public void StartThreads()
//    {
//        Thread thread1 = new Thread(PrintNumbers);
//        Thread thread2 = new Thread(PrintNumbers);

//        thread1.Start();
//        thread2.Start();
//    }

//    private void PrintNumbers()
//    {
//        for (int i = 1; i <= 5; i++)
//        {
//            Console.WriteLine(i);
//            Thread.Sleep(100); // Simulate work
//        }
//    }
//}

// Delegates in c sharp


//public delegate void PrintMessage(string message);

//public class DelegateExample
//{
//    public void Execute()
//    {
//        PrintMessage printDel = ShowMessage;
//        printDel("Hello, Delegates!");
//    }

//    private void ShowMessage(string message)
//    {
//        Console.WriteLine(message);
//    }
//}

// Anonymus method
//public class AnonymousMethodExample
//{
//    public void Execute()
//    {
//        PrintMessage printDel = delegate (string message)
//        {
//            Console.WriteLine(message);
//        };

//        printDel("Hello from Anonymous Method!");
//    }
//}

//async await
//using System;
//using System.Net.Http;
//using System.Threading.Tasks;

//public class AsyncAwaitExample
//{
//    public async Task FetchData()
//    {
//        HttpClient client = new HttpClient();
//        string data = await client.GetStringAsync("https://jsonplaceholder.typicode.com/posts/1");
//        Console.WriteLine(data);
//    }
//}


// collections

//public class CollectionExample
//{
//    private List<string> items = new List<string>();

//    public void AddItem(string item)
//    {
//        items.Add(item);
//    }

//    public IEnumerable<string> GetAllItems()
//    {
//        return items;
//    }
//}

                                                 // list
//public class NumberList
//{
//    private List<int> numbers = new List<int>();

//    public void AddNumber(int number)
//    {
//        numbers.Add(number);
//    }

//    public List<int> GetNumbers()
//    {
//        return numbers;
//    }
//}


