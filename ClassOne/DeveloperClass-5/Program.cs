using System;
using Bank;
using ketabkhoone;

namespace DeveloperClass_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Person pOne = new Person()
            {
                FirstName = "Shahab",
                LastName = "Noori Goodarzi",
                MelliCode = "1236698853",
                MobileNumber = "09359167820"
            };

            pOne.MobileNumber = "09123565656";

            Book book = new Book()
            {
                Isbn = "121212",
                Name = "Nemoneh"
            };

            Foroshgah.Book bookOne = new Foroshgah.Book()
            {
                Name = "Nemoneh man",
                Isbn = "21121212",
                Price = 1200
            };

            //Console.WriteLine(pOne.FirstName + " " + pOne.LastName);
            //Console.WriteLine($"{pOne.FirstName} {pOne.LastName} ===> {pOne.MobileNumber}");

            Dog dog = new Dog()
            {
                Name = "Poppy"
            };

            //dog.Eat();

            Calculator calculator = new Calculator()
            {
                NumberOne = 10
            };

            //if (calculator.NumberTwoSetter(0) != true)
            //{
            //    calculator.NumberTwoSetter(Convert.ToInt32(Console.ReadLine()));
            //}

            bool result = false;
            while (result == false)
            {
                result = calculator.NumberTwoSetter(Convert.ToInt32(Console.ReadLine()));
            }

            Console.WriteLine(calculator.Add());
            Console.WriteLine(calculator.Sub());
            Console.WriteLine(calculator.Div());
            Console.WriteLine(calculator.Mul());
        }
    }
}

