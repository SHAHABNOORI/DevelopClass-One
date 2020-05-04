using System;

namespace DeveloperClass_1
{
    class Program
    {
        static void Main(string[] args)
        {
            /* int tike code yek matn 
                 ra roye safhe chap 
                 mikonad */

            //int x = 10;
            //int y = x;
            //y = y + 10;
            //Console.WriteLine(x);
            //Console.WriteLine(y);


            Calculator cOne = new Calculator() { X = 10, Y = 20 };
            Calculator cTwo = cOne;

            cTwo.X = 100;
            cTwo.Y = 250;

            Console.WriteLine(cOne.X);
            Console.WriteLine(cOne.Y);

            Console.ReadKey();
        }
    }

    class Calculator
    {
        public int X { get; set; }

        public int Y { get; set; }
    }
}

