using System;
using System.Collections.Generic;
using System.Linq;
using DeveloperClass_7.Models;

namespace DeveloperClass_8
{
    class Program
    {
        static void Main(string[] args)
        {
            IMessageSender s = new TelegramSender();

            SendMessageToCustomer(s, "Shahab", "Noori Goodarzi");

            //WorkWithGenericList();

            //SampleWithGenericList();
        }

        public static void SendMessageToCustomer(IMessageSender sender, string firstName, string lastName)
        {
            sender.SendMessage(firstName, lastName);
        }

        private static void WorkWithGenericList()
        {
            //List<int> numbers = new List<int>()
            //{
            //    20,25,326,25,64,64,6,81
            //};

            //List<int> numbers = new List<int>
            //{
            //    20,
            //    25,
            //    326,
            //    25,
            //    64,
            //    64,
            //    6,
            //    81,
            //    526,
            //    852,
            //    521596,
            //    3534
            //};

            var numbers = new List<int>
            {
                20,
                25,
                326,
                25,
                64,
                64,
                6,
                81,
                526,
                852,
                521596,
                3534
            };

            var result = numbers.Where(number => number > 100);

            foreach (var number in result)
            {
                Console.WriteLine(number);
            }
        }

        public static string SayHello(string fullName) => $"Hello World {fullName}";

        private static void SampleWithGenericList()
        {
            List<Selection> selectionList = new List<Selection>();
            //Selection[] selectionList = new Selection[20];

            Student studentOne = new Student("Shahab", "Noori Goodarzi");
            Console.WriteLine(studentOne.Identity);
            Console.WriteLine("---------------------------------------------------------------");

            Teacher teacherOne = new Teacher("Hamid", "Molai");
            Console.WriteLine(teacherOne.Identity);
            Console.WriteLine("---------------------------------------------------------------");

            Course courseOne = new Course("C# Programming", 3);
            Console.WriteLine(courseOne.Identity);
            Console.WriteLine("---------------------------------------------------------------");

            Course courseTwo = new Course("Java Programming", 4);
            Console.WriteLine(courseTwo.Identity);
            Console.WriteLine("---------------------------------------------------------------");

            Course courseThree = new Course("Php Programming", 5);
            Console.WriteLine(courseThree.Identity);
            Console.WriteLine("---------------------------------------------------------------");

            Course courseFour = new Course("Python Programming", 2);
            Console.WriteLine(courseFour.Identity);
            Console.WriteLine("---------------------------------------------------------------");

            Course courseFive = new Course("Java script Programming", 1);
            Console.WriteLine(courseFive.Identity);
            Console.WriteLine("---------------------------------------------------------------");

            ClassRoom classRoomOne = new ClassRoom("Ferdoosi", 5, 16);
            Console.WriteLine(classRoomOne.Identity);

            Console.WriteLine("---------------------------------------------------------------");

            Present presentOne = new Present(courseOne, classRoomOne, teacherOne);
            Console.WriteLine(presentOne.Identiy);
            Console.WriteLine("---------------------------------------------------------------");

            Present presentTwo = new Present(courseTwo, classRoomOne, teacherOne);
            Console.WriteLine(presentTwo.Identiy);
            Console.WriteLine("---------------------------------------------------------------");

            Present presetnThree = new Present(courseThree, classRoomOne, teacherOne);
            Console.WriteLine(presetnThree.Identiy);
            Console.WriteLine("---------------------------------------------------------------");

            Present presentFour = new Present(courseFour, classRoomOne, teacherOne);
            Console.WriteLine(presentFour.Identiy);
            Console.WriteLine("---------------------------------------------------------------");

            Present presentFive = new Present(courseFive, classRoomOne, teacherOne);
            Console.WriteLine(presentFive.Identiy);
            Console.WriteLine("---------------------------------------------------------------");
            int count = 0;
            EntekhabVahed(selectionList, studentOne, presentOne, count++);
            EntekhabVahed(selectionList, studentOne, presentTwo, count++);
            EntekhabVahed(selectionList, studentOne, presetnThree, count++);
            EntekhabVahed(selectionList, studentOne, presentFive, count++);
            EntekhabVahed(selectionList, studentOne, presentFour, count);
        }

        static void EntekhabVahed(List<Selection> selectionList, Student student, Present present, int count)
        {
            //if (selectionList[0] != null)
            if (selectionList.Count != 0)
            {
                var units = 0;
                foreach (var selection in selectionList)
                {
                    if (selection != null)
                        units = units + selection.Present.Course.Unit;
                }
                if (units + present.Course.Unit < 10)
                {
                    Selection selectionOne = new Selection(student, present);
                    selectionList.Add(selectionOne);
                    //selectionList[count] = selectionOne;
                    Console.WriteLine(selectionOne.Identity);
                    Console.WriteLine("---------------------------------------------------------------");
                }
                else
                {
                    Console.WriteLine("Shoma hade aksar tedad vahed morede nazar ra bardashteid");
                    Console.WriteLine("---------------------------------------------------------------");
                }
            }
            else
            {

                Selection selectionOne = new Selection(student, present);
                selectionList.Add(selectionOne);
                //selectionList[count] = selectionOne;
                Console.WriteLine(selectionOne.Identity);
                Console.WriteLine("---------------------------------------------------------------");
            }
        }
    }
}
