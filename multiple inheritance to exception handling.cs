/*multiple inheritance using interfaces*/


//using System;

//interface IPrintable
//{
//    void Print();
//}

//interface IScannable
//{
//    void Scan();
//}

//class MultiFunctionPrinter : IPrintable, IScannable
//{
//    public void Print()
//    {
//        Console.WriteLine("Printing document...");
//    }

//    public void Scan()
//    {
//        Console.WriteLine("Scanning document...");
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        MultiFunctionPrinter mfp = new MultiFunctionPrinter();
//        mfp.Print();
//        mfp.Scan();
//    }
//}



//delegates in c sharp 

//using System;

//delegate int Operation(int x, int y);

//class Calculator
//{
//    public int Add(int a, int b)
//    {
//        return a + b;
//    }

//    public int Subtract(int a, int b)
//    {
//        return a - b;
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        Calculator calculator = new Calculator();

//        Operation addOperation = new Operation(calculator.Add);
//        Operation subtractOperation = new Operation(calculator.Subtract);

//        int resultAdd = addOperation(5, 3);
//        int resultSubtract = subtractOperation(5, 3);

//        Console.WriteLine("Addition: " + resultAdd);
//        Console.WriteLine("Subtraction: " + resultSubtract);
//    }
//}

//                     enum in c sharp
//using System;

//enum DaysOfWeek
//{
//    Sunday,    
//    Monday,    
//    Tuesday,   
//    Wednesday, 
//    Thursday,  
//    Friday,    
//    Saturday   
//}

//class Program
//{
//    static void Main()
//    {
//        DaysOfWeek today = DaysOfWeek.Monday;

//        Console.WriteLine("Today is: " + today); 


//        int dayNumber = (int)today;
//        Console.WriteLine("Day number: " + dayNumber); 

//        switch (today)
//        {
//            case DaysOfWeek.Monday:
//                Console.WriteLine("Start of the workweek.");
//                break;
//            case DaysOfWeek.Friday:
//                Console.WriteLine("Almost the weekend!");
//                break;
//            case DaysOfWeek.Sunday:
//                Console.WriteLine("Time to relax.");
//                break;
//            default:
//                Console.WriteLine("Another day.");
//                break;
//        }
//    }
//}

//           Error handling in c sharp
//using System;

//class Program
//{
//    static void Main()
//    {
//        try
//        {
//            ValidateAge(15);
//        }
//        catch (Exception ex)
//        {
//            Console.WriteLine(ex.Message);
//        }
//    }

//    static void ValidateAge(int age)
//    {
//        if (age < 18)
//        {
//            throw new ArgumentException("Age must be 18 or older.");
//        }
//        Console.WriteLine("Age is valid.");
//    }
//}
