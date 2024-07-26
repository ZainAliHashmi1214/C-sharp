using System;

namespace Part3
{
    public class AbsChild : AbsParent
    {
        public override void Mul(int x, int y)
        {
            Console.WriteLine(x * y);
        }
        public override void Div(int x, int y)
        {
            Console.WriteLine(x / y);
        }
        static void Main ()
        {
            AbsChild c = new AbsChild();
            c.Add(1, 2); c.Sub(4,7);
            c.Mul(5,6);c.Div(6,7);
            Console.ReadLine();
        }
    }
}
