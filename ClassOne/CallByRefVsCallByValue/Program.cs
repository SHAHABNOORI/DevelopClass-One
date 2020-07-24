using System;

namespace CallByRefVsCallByValue
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOne = 10;
            int numTwo = 20;
            //Sum(ref numOne, ref numTwo);
            //Minus(out numTwo, out numOne);
            //Console.WriteLine($"numeOne : {numOne}");
            //Console.WriteLine($"numTwo : {numTwo}");
            Person person = new Person()
            {
                FullName = "Shahab Noori Goodarzi",
                Address = new Address()
                {
                    Street = "ShahinVilla",
                    City = "Karaj"
                }
            };
            Register(ref person);

            Console.WriteLine(person.FullName);
        }

        static void Sum(ref int x, ref int y)
        {
            x = 100;
            y = 200;
            Console.WriteLine(x + y);
        }

        static void Minus(out int x, out int y)
        {
            x = 100;
            y = 200;
            Console.WriteLine(x + y);
        }

        static void Register(Person person)
        {
            person = new Person()
            {
                FullName = "Hamid Molai",
                Address = new Address()
                {
                    Street = "350",
                    City = "Tehran"
                }
            };
            Console.WriteLine($"{person.FullName} with address {person.Address.City} {person.Address.Street} , has beed registered");
            Console.WriteLine("---------------------------------------------------------------------------------------------------");
            person.FullName = "Shahab Noori";
        }

        static void Register(ref Person person)
        {
            person = new Person()
            {
                FullName = "Hamid Molai",
                Address = new Address()
                {
                    Street = "350",
                    City = "Tehran"
                }
            };
            Console.WriteLine($"{person.FullName} with address {person.Address.City} {person.Address.Street} , has beed registered");
            Console.WriteLine("---------------------------------------------------------------------------------------------------");
            //person.FullName = "Shahab Noori";
        }
    }
}
