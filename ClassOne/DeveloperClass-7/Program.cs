using System;
using DeveloperClass_7.Models;

namespace DeveloperClass_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Student studentOne = new Student("Shahab", "Noori Goodarzi");
            Console.WriteLine(studentOne.Identity);

            Teacher teacherOne = new Teacher("Hamid", "Molai");
            Console.WriteLine(teacherOne.Identity);

            Course courseOne = new Course("C# Programming", 3);
            Console.WriteLine(courseOne.Identity);

            ClassRoom classRoomOne = new ClassRoom("Ferdoosi", 5, 16);
            Console.WriteLine(classRoomOne.Identity);

            Console.WriteLine("---------------------------------------------------------------");

            Present presentOne = new Present(courseOne, classRoomOne, teacherOne);
            Console.WriteLine(presentOne.Identiy);
        }
    }
}
