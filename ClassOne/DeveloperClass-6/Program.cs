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

            //Book csharpBook = new Book()
            //{
            //    Id = 60021,
            //    Isbn = "1245a",
            //    Title = "How to code CSharp"
            //};

            //Author author = new Author()
            //{
            //    Id = 2006,
            //    FirstName = "Shahab",
            //    LastName = "Noori Goodarzi"
            //};

            //author.Book = csharpBook;
            //Console.WriteLine($"{author.FirstName} {author.LastName} write {author.Book?.Title}");

            //int[] numbers = { 1, 2, 3, 4, 5, 6, 7 };
            ////numbers[8] = 1212; ERRoR

            //numbers[3] = 265;
            //Console.WriteLine(numbers[3]);

            //int[] nums = new int[6];

            //nums[3] = 2564;

            //Console.WriteLine(nums[3]);

            Book csharpBook = new Book()
            {
                Id = 60021,
                Isbn = "1245a",
                Title = "How to code CSharp"
            };

            Book htmlBook = new Book()
            {
                Id = 60021,
                Isbn = "1245a",
                Title = "How to code Html"
            };

            Book cPlusPlusBook = new Book()
            {
                Id = 60021,
                Isbn = "1245a",
                Title = "How to code C++"
            };

            Author author = new Author(2)
            {
                Id = 2006,
                FirstName = "Shahab",
                LastName = "Noori Goodarzi"
            };

            author.Books[0] = csharpBook;
            author.Books[1] = htmlBook;
            author.Books[2] = cPlusPlusBook;

            Console.WriteLine($"{author.FirstName} {author.LastName} write {author.Books[1].Title}");

        }
    }
}

//Collection

//Array

//Initialize

// Syntax Sugar => Property