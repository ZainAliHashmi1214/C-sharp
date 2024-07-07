//using System;

//namespace Method_Overloading
//{
//    class ParentClass
//    {
//        public virtual void Test1()
//        {
//            Console.WriteLine("1st Method P is Called");
//        }

//        public virtual void Test2()
//        {
//            Console.WriteLine("2nd Method P is Called");
//        }
//    }

//    class ChildClass : ParentClass
//    {
//        // Optionally override the methods in the derived class
//        public override void Test1()
//        {
//            Console.WriteLine("1st Method C is Called");
//        }

//        public override void Test2()
//        {
//            Console.WriteLine("2nd Method C is Called");
//        }

//        static void Main()
//        {
//            ParentClass p = new ParentClass();
//            p.Test1();
//            p.Test2();

//            ChildClass c = new ChildClass();
//            c.Test1();
//            c.Test2();

//            Console.ReadLine();
//        }
//    }
//}
