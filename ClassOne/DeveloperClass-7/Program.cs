using System;
using DeveloperClass_7.Models;

namespace DeveloperClass_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Selection[] selectionList = new Selection[20];

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

        static void EntekhabVahed(Selection[] selectionList, Student student, Present present, int count)
        {
            if (selectionList[0] != null)
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
                    selectionList[count] = selectionOne;
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
                selectionList[count] = selectionOne;
                Console.WriteLine(selectionOne.Identity);
                Console.WriteLine("---------------------------------------------------------------");
            }
        }
    }
}
