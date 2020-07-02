using System;

namespace MethodDefaultParameterValueSample
{
    class Program
    {
        static void MyMethod(/*string city,*/ string country = "Norway")
        {
            Console.WriteLine(country);
        }

        static void Main(string[] args)
        {
            MyMethod("Sweden");
            MyMethod("India");
            MyMethod();
            MyMethod("USA");
        }
    }
}
