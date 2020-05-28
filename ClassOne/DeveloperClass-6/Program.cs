using System;

namespace DeveloperClass_6
{
    class Program
    {
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

            Teacher teacher = new Teacher("Shahab Noori Goodarzi");
            Console.WriteLine(teacher.FullName);

            Teacher teacherRiazi = new Teacher()
            {
                FullName = "Hamidreza Moini"
            };
            Console.WriteLine(teacherRiazi.FullName);


        }
    }
}
