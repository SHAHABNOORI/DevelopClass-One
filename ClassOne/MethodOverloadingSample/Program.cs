using System;

namespace MethodOverloadingSample
{
    class Program
    {
        static int PlusMethod(int x, int y) => x + y;

        static double PlusMethod(double x, double y) => x + y;

        static void Main(string[] args)
        {
            int myNum1 = PlusMethod(8, 5);
            double myNum2 = PlusMethod(4.3, 6.26);
            Console.WriteLine("Int: " + myNum1);
            Console.WriteLine("Double: " + myNum2);
        }
    }
}
