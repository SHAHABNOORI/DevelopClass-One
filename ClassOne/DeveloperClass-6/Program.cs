using System;

namespace DeveloperClass_6
{
    class Program
    {
        //static void SayHello()
        //{
        //    Console.WriteLine("Hello World");
        //}

        //Expression Body

        static void SayHelloVersion() => Console.WriteLine("Hello World");


        //static int Add(int numberOne, int numberTwo)
        //{
        //    return numberOne + numberTwo;
        //}

        // Expression Body

        static int AddVersion(int x, int y) => x + y;

        static void Main(string[] args)
        {
            //Daneshjoo daneshjoo = new Daneshjoo()
            //{
            //    FirstName = "Shahab",
            //    LastName = "Noori Goodarzi",
            //    MobileNumber = "093159167820",
            //    DaneshjooId = 2005
            //};
            //Console.Write("Please Enter Your First Name :: ");
            //daneshjoo.FirstName = Console.ReadLine();

            //Console.Write("Please Enter Your Last Name :: ");
            //daneshjoo.LastName = Console.ReadLine();

            //Console.Write("Please Enter Your Mobile Number :: ");
            //daneshjoo.MobileNumber = Console.ReadLine();

            //Console.WriteLine(daneshjoo.FirstName + " " + daneshjoo.LastName + " " + daneshjoo.DaneshjooId + " " + daneshjoo.MobileNumber);

            //Person person = new Person(2017, "Shahab", "Noori Goodarzi", "09359167820");

            //person.PrintPerson();

            //Teacher teacher = new Teacher("Shahab Noori Goodarzi");
            //Console.WriteLine(teacher.FullName);

            //Teacher teacherRiazi = new Teacher()
            //{
            //    FullName = "Hamidreza Moini"
            //};

            //Console.WriteLine(teacherRiazi.FullName);


            //Student st = new Student()
            //{
            //    Id = 2050,
            //    FirstName = "Shahab",
            //    LastName = "Noori Goodarzi",
            //    MobileNumber = "09359167820",
            //    Age = 0
            //};
            //st.Address = "---------------"; ERROR

            //Console.WriteLine($"{st.Id} {st.FirstName} {st.LastName} {st.MobileNumber} ");

            //var result = AddVersion(2, 10);
            //Console.WriteLine(result);

            //Author author = new Author()
            //{
            //    Id = 2006,
            //    FirstName = "Shahab",
            //    LastName = "Noori Goodarzi",
            //    Book = new Book()
            //    {
            //        Id = 60021,
            //        Isbn = "1245a",
            //        Title = "How to code CSharp"
            //    }
            //};

            Book csharpBook = new Book()
            {
                Id = 60021,
                Isbn = "1245a",
                Title = "How to code CSharp"
            };

            Author author = new Author()
            {
                Id = 2006,
                FirstName = "Shahab",
                LastName = "Noori Goodarzi"
            };

            author.Book = csharpBook;
            Console.WriteLine($"{author.FirstName} {author.LastName} write {author.Book?.Title}");
        }
    }
}

//Initialize

// Syntax Sugar => Property