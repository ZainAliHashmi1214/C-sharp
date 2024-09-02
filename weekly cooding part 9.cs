//multicast delgates in c sharp


//using System;

//delegate void Notify();

//class Program
//{
//    static void Main()
//    {
//        Notify notify = NotifyMethod1;
//        notify += NotifyMethod2;
//        notify += NotifyMethod3;

//        notify();

//        notify -= NotifyMethod2;

//        notify();
//    }

//    static void NotifyMethod1() => Console.WriteLine("Method 1");
//    static void NotifyMethod2() => Console.WriteLine("Method 2");
//    static void NotifyMethod3() => Console.WriteLine("Method 3");
//}


//Exception handling in c sharp
//using System;

//class Program
//{
//    static void Main()
//    {
//        try
//        {
//            int number = int.Parse("invalid");
//        }
//        catch (FormatException ex)
//        {
//            Console.WriteLine("Format exception: " + ex.Message);
//        }
//        catch (Exception ex)
//        {
//            Console.WriteLine("General exception: " + ex.Message);
//        }
//        finally
//        {
//            Console.WriteLine("Finally block executed");
//        }
//    }
//}

//enums in c sharp

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
//        DaysOfWeek today = DaysOfWeek.Wednesday;

//        if (today == DaysOfWeek.Wednesday)
//        {
//            Console.WriteLine("It's midweek!");
//        }

//        Console.WriteLine($"Today is {today}");
//        Console.WriteLine($"Numeric value of {today} is {(int)today}");
//    }
//}

//acess modifiers in c sharp

//using System;

//class Person
//{
//    public string Name { get; set; }
//    private int age;
//    protected string Gender { get; set; }

//    internal void SetAge(int age)
//    {
//        this.age = age;
//    }

//    protected internal void DisplayInfo()
//    {
//        Console.WriteLine($"Name: {Name}, Age: {age}, Gender: {Gender}");
//    }

//    private protected void ShowAge()
//    {
//        Console.WriteLine($"Age is {age}");
//    }
//}

//class Employee : Person
//{
//    public void ShowDetails()
//    {
//        Name = "John";
//        Gender = "Male";
//        SetAge(30);
//        DisplayInfo();
//        ShowAge();
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        Employee emp = new Employee();
//        emp.ShowDetails();
//    }
//}



                    //Reflection in c sharp

//using System;
//using System.Reflection;

//class Sample
//{
//    public int Id { get; set; }
//    public string Name { get; set; }

//    public void Display() => Console.WriteLine("Display method called");
//}

//class Program
//{
//    static void Main()
//    {
//        Type type = typeof(Sample);

//        Console.WriteLine("Properties:");
//        foreach (PropertyInfo prop in type.GetProperties())
//        {
//            Console.WriteLine(prop.Name);
//        }

//        Console.WriteLine("Methods:");
//        foreach (MethodInfo method in type.GetMethods())
//        {
//            Console.WriteLine(method.Name);
//        }

//        object obj = Activator.CreateInstance(type);
//        MethodInfo displayMethod = type.GetMethod("Display");
//        displayMethod.Invoke(obj, null);
//    }
//}
