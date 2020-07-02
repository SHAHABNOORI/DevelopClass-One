using System;

namespace StaticSample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Calculator.Plus(21d, 2));

            CalculatorTwo calculatorTwo=new CalculatorTwo();
            Console.WriteLine(calculatorTwo.Mul(2, 5));

            Console.WriteLine(CalculatorTwo.Minus(100, 50));

        }
    }
}
