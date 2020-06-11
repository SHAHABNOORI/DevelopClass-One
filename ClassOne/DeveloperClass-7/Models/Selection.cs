using System;

namespace DeveloperClass_7.Models
{
    public class Selection
    {
        public Selection(Student student, Present present)
        {
            Id = Guid.NewGuid();
            Student = student;
            Present = present;
        }

        public Guid Id { get; }

        public Student Student { get; set; }

        public Present Present { get; set; }

        public string Identity => $"Selection :: {Id} ; Student :: {Student.Identity} ; Presented :: {Present.Identiy}";
    }
}