//Method hiding in c sharp


//using System;

//class BaseClass
//{
//    public void Display()
//    {
//        Console.WriteLine("Display method from BaseClass");
//    }
//}

//class DerivedClass : BaseClass
//{
//    public new void Display()
//    {
//        Console.WriteLine("Display method from DerivedClass");
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        BaseClass obj1 = new BaseClass();
//        obj1.Display();

//        DerivedClass obj2 = new DerivedClass();
//        obj2.Display();

//        BaseClass obj3 = new DerivedClass();
//        obj3.Display();
//    }
//}

//Method Overding in c sharp

//using System;

//class BaseClass
//{
//    public virtual void Display()
//    {
//        Console.WriteLine("Display method from BaseClass");
//    }
//}

//class DerivedClass : BaseClass
//{
//    public override void Display()
//    {
//        Console.WriteLine("Display method from DerivedClass");
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        BaseClass obj1 = new BaseClass();
//        obj1.Display();

//        DerivedClass obj2 = new DerivedClass();
//        obj2.Display();

//        BaseClass obj3 = new DerivedClass();
//        obj3.Display();
//    }
//}


//Method Overloading in c sharp

//using System;

//class ExampleClass
//{
//    public void Display()
//    {
//        Console.WriteLine("Display method with no parameters");
//    }

//    public void Display(string message)
//    {
//        Console.WriteLine("Display method with a string parameter: " + message);
//    }

//    public void Display(int number)
//    {
//        Console.WriteLine("Display method with an int parameter: " + number);
//    }

//    public void Display(string message, int number)
//    {
//        Console.WriteLine("Display method with a string and an int parameter: " + message + ", " + number);
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        ExampleClass example = new ExampleClass();

//        example.Display();
//        example.Display("Hello, World!");
//        example.Display(42);
//        example.Display("Answer", 42);
//    }
//}

//properties in c sharp

//using System;

//class Person
//{
//    private string name;
//    private int age;

//    public string Name
//    {
//        get { return name; }
//        set { name = value; }
//    }

//    public int Age
//    {
//        get { return age; }
//        set { age = value; }
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        Person person = new Person();
//        person.Name = "John Doe";
//        person.Age = 30;

//        Console.WriteLine("Name: " + person.Name);
//        Console.WriteLine("Age: " + person.Age);
//    }
//}
