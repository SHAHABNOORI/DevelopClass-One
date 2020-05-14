using System;

namespace DeveloperClass_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //int numOne = 20;

            //double numTwo = 20.6565656;

            //float numThree = 20.6f;

            //bool shart = true;

            //string fullName = "Shahab Noori Goodarzi";

            //char ch = 'a';

            //byte b = 255;

            //var test = 20.85f;

            //int a = 30;
            //int b = 30;

            //var result = (a <= b);

            //var result = (-(1) + 6 / 2 * 7 * 3 - 3 + (2 * 6) * 3) == (2 + 60);

            //var result = a++;
            //var result = ++a;
            //var result = a--;

            //Console.WriteLine(result);
            //Console.WriteLine(a);

            //var s = "22";
            //var x = "33";
            //Console.WriteLine(s+x);

            //int vorodi = 0;

            //vorodi = Convert.ToInt32(Console.ReadLine());

            //if ((vorodi % 2 == 0) || (vorodi % 5 == 0))
            //{
            //    Console.WriteLine("Adad bar 2 va 5 bakhshpazir ast");
            //}
            //else
            //{
            //    Console.WriteLine("Adad bar 2 va 5 bakhshpazir nist");
            //}


            int vorodi = 0;

            vorodi = Convert.ToInt32(Console.ReadLine());

            if (vorodi % 2 == 0)
            {
                Console.WriteLine("Adad bar 2 bakhshpazir ast");
            }
            else if (vorodi % 5 == 0)
            {
                Console.WriteLine("Adad bar 5 bakhshpazir ast");
            }
            else if (vorodi % 7 == 0)
            {
                Console.WriteLine("Adad bar 7 bakhshpazir ast");
            }
            else
            {
                Console.WriteLine("Adad bar 2 va 5 bakhshpazir nist");
            }
        }
    }
}

