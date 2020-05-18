using System;

namespace DeveloperClass_4
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Adad Aval

            //int myNum = 0;
            //myNum = Convert.ToInt32(Console.ReadLine());

            //if (myNum == 1 || myNum == 2 || myNum == 3 || myNum == 5 || myNum == 7)
            //{
            //    Console.WriteLine("Adad Aval Ast");
            //}
            //else if ((myNum % 2 != 0) && (myNum % 3 != 0) && (myNum % 5 != 0) && (myNum % 7 != 0))
            //{
            //    Console.WriteLine("Adad Aval Ast");
            //}
            //else
            //{
            //    Console.WriteLine("Adad Aval Nist");
            //}

            #endregion

            #region Jadval Zarb

            //for (int i = 1; i <= 10; i++)
            //{
            //    for (int j = 1; j <= 10; j++)
            //    {
            //        Console.Write(i*j +"\t");
            //    }
            //    Console.WriteLine();
            //}

            #endregion

            #region SwitchCase Sample

            //int myNum = Convert.ToInt32(Console.ReadLine());

            //switch (myNum)
            //{
            //    case 1:
            //        Console.WriteLine("One");
            //        break;
            //    case 2:
            //        Console.WriteLine("Two");
            //        break;
            //    case 3:
            //        Console.WriteLine("Three");
            //        break;
            //    case 4:
            //        Console.WriteLine("Four");
            //        break;
            //    case 5:
            //        Console.WriteLine("Five");
            //        break;
            //    default:
            //        Console.WriteLine("Number is out of range");
            //        break;
            //}

            #endregion

            //Console.WriteLine(CalculateTax(5000000));

            #region Calculator

            //int x = Convert.ToInt32(Console.ReadLine());
            //int y = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine(Add(x, y));

            #endregion

            //int x = Convert.ToInt32(Console.ReadLine());
            //int y = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine(CustomeCalculator(x, y,'+'));



            //for (int i = 1; i < 1000; i++)
            //{
            //    if ((i % 7 == 0) && (i % 3 == 0) && (i % 9 == 0))
            //    {
            //        break;
            //    }
            //    Console.WriteLine(i);
            //}

            for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    if (j == 5)
                    {
                        break;
                    }
                    Console.Write(i*j+"\t");
                }
                Console.WriteLine();
            }

        }

        static int CustomeCalculator(int x, int y, char operation)
        {
            int result = 0;
            switch (operation)
            {
                case '*':
                    result = x * y;
                    break;
                case '/':
                    result = x / y;
                    break;
                case '+':
                    result = x + y;
                    break;
                case '-':
                    result = x - y;
                    break;
            }

            return result;
        }

        #region Calculator Methods

        static int Add(int numberOne, int numberTwo)
        {
            return numberOne + numberTwo;
        }

        static int Sub(int numberOne, int numberTwo)
        {
            return numberOne - numberTwo;
        }

        static int Mult(int numberOne, int numberTwo)
        {
            return numberOne * numberTwo;
        }

        static int Division(int numberOne, int numberTwo)
        {
            return numberOne / numberTwo;
        }

        static int CalculateTax(int salary)
        {
            int result = (salary / 100) * 9;
            return result;
        }


        #endregion
    }
}


//method signature