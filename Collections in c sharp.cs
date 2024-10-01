using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<int> numbers = new List<int>();
        numbers.Add(1);
        numbers.Add(2);
        numbers.Add(3);

        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }

        Dictionary<string, int> ages = new Dictionary<string, int>();
        ages["Alice"] = 30;
        ages["Bob"] = 25;

        foreach (KeyValuePair<string, int> entry in ages)
        {
            Console.WriteLine(entry.Key + " is " + entry.Value + " years old");
        }

        Queue<string> queue = new Queue<string>();
        queue.Enqueue("First");
        queue.Enqueue("Second");
        queue.Enqueue("Third");

        while (queue.Count > 0)
        {
            Console.WriteLine(queue.Dequeue());
        }

        Stack<string> stack = new Stack<string>();
        stack.Push("Top");
        stack.Push("Middle");
        stack.Push("Bottom");

        while (stack.Count > 0)
        {
            Console.WriteLine(stack.Pop());
        }
    }
}

