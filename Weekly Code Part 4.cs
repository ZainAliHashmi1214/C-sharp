//using System;

//-----------OverloadingExample-----------



//class  OverloadingExample
//{
//    public void Display(int a)
//    {
//        Console.WriteLine("Integer: " + a);
//    }

//    public void Display(double a)
//    {
//        Console.WriteLine("Double: " + a);
//    }

//    public void Display(string a)
//    {
//        Console.WriteLine("String: " + a);
//    }

//    static void Main()
//    {
//        OverloadingExample example = new OverloadingExample();
//        example.Display(5);
//        example.Display(3.14);
//        example.Display("Hello");
//    }
//}


//-------------Method Hiding---------------

//using System;

//class BaseClass
//{
//    public void Show()
//    {
//        Console.WriteLine("BaseClass Show");
//    }
//}

//class DerivedClass : BaseClass
//{
//    public new void Show()
//    {
//        Console.WriteLine("DerivedClass Show");
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        BaseClass baseObj = new BaseClass();
//        baseObj.Show();

//        DerivedClass derivedObj = new DerivedClass();
//        derivedObj.Show();

//        BaseClass baseDerivedObj = new DerivedClass();
//        baseDerivedObj.Show();  
//    }
//}



//-------Inheritance---------


//using System;

//class BaseClass
//{
//    public void BaseMethod()
//    {
//        Console.WriteLine("BaseClass Method");
//    }
//}

//class DerivedClass : BaseClass
//{
//    public void DerivedMethod()
//    {
//        Console.WriteLine("DerivedClass Method");
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        DerivedClass derived = new DerivedClass();
//        derived.BaseMethod();
//        derived.DerivedMethod();
//    }
//}


//----------Polymorphism--------

//using System;

//class BaseClass
//{
//    public virtual void Show()
//    {
//        Console.WriteLine("BaseClass Show");
//    }
//}

//class DerivedClass : BaseClass
//{
//    public override void Show()
//    {
//        Console.WriteLine("DerivedClass Show");
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        BaseClass baseObj = new BaseClass();
//        baseObj.Show();

//        DerivedClass derivedObj = new DerivedClass();
//        derivedObj.Show();

//        BaseClass baseDerivedObj = new DerivedClass();
//        baseDerivedObj.Show();  // Calls DerivedClass Show
//    }
//}
