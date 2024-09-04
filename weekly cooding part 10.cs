//reflection in c sharp

//using System;
//using System.Reflection;

//class Program
//{
//    static void Main()
//    {
//        Type type = typeof(Sample);
//        MethodInfo method = type.GetMethod("Display");
//        object obj = Activator.CreateInstance(type);
//        method.Invoke(obj, null);
//    }
//}

//class Sample
//{
//    public void Display()
//    {
//        Console.WriteLine("Reflection Example");
//    }
//}


//late binding using reflection in c sharp
//using System;
//using System.Reflection;

//class Program
//{
//    static void Main()
//    {
//        Type type = Type.GetType("Sample");
//        object obj = Activator.CreateInstance(type);
//        type.InvokeMember("Display", BindingFlags.InvokeMethod, null, obj, null);
//    }
//}

//class Sample
//{
//    public void Display()
//    {
//        Console.WriteLine("Late Binding Example");
//    }
//}

//generics in c sharp
//using System;
//using System.Reflection;

//class Program
//{
//    static void Main()
//    {
//        Type type = Type.GetType("Sample");
//        object obj = Activator.CreateInstance(type);
//        type.InvokeMember("Display", BindingFlags.InvokeMethod, null, obj, null);
//    }
//}

//class Sample
//{
//    public void Display()
//    {
//        Console.WriteLine("Late Binding Example");
//    }
//}
