using System;

namespace DeveloperClass_9
{
    class Program
    {
        static void Main(string[] args)
        {
            //Person person = new Person(Guid.NewGuid(), "Shahab");

            Karmand karmand=new KarmandHesabdari();

            KarmandEdari person=new KarmandEdari();
            
            //person.Console.WriteLine(person.LastName);
            //PracticeStudent();
        }

        private static void PracticeStudent()
        {
            Student studentOne = new Student()
            {
                LastName = "Noori Goodarzi",
                Addrress = "Karaj",
                Age = 0
            };

            studentOne.SetFirstName("Shahab");

            var result = studentOne.GetFullData();

            Console.WriteLine(result);
        }
    }
}
