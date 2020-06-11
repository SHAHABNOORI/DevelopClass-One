using System;

namespace DeveloperClass_7.Models
{
    public class Present
    {
        public Present(Course course, ClassRoom classRoom, Teacher teacher)
        {
            Id = Guid.NewGuid();
            Course = course;
            ClassRoom = classRoom;
            Teacher = teacher;
        }

        public Guid Id { get; }

        public Course Course { get; set; }

        public ClassRoom ClassRoom { get; set; }

        public Teacher Teacher { get; set; }

        public string Identiy =>
            $"Id : {Id} ; Course :: {Course.Identity} ; ClassRoom :: {ClassRoom.Identity} ; Teacher :: {Teacher.Identity}";
    }
}