                  //abstract classes in c sharp

//using System;

//abstract class Shape
//{
//    public abstract double GetArea();
//}

//class Circle : Shape
//{
//    private double radius;

//    public Circle(double radius)
//    {
//        this.radius = radius;
//    }

//    public override double GetArea()
//    {
//        return Math.PI * radius * radius;
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        Shape shape = new Circle(5);
//        Console.WriteLine(shape.GetArea());
//    }
//}




                      //delgates in c sharp



//using System;

//delegate int MathOperation(int a, int b);

//class Program
//{
//    static int Add(int a, int b)
//    {
//        return a + b;
//    }

//    static int Multiply(int a, int b)
//    {
//        return a * b;
//    }

//    static void Main()
//    {
//        MathOperation operation;

//        operation = Add;
//        Console.WriteLine(operation(3, 4));

//        operation = Multiply;
//        Console.WriteLine(operation(3, 4));
//    }
//}

