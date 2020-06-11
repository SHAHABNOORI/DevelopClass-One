using System;

namespace DeveloperClass_7.Models
{
    public class Course
    {
        public Course(string title, int unit)
        {
            Id = Guid.NewGuid();
            Title = title;
            Unit = unit;
        }

        public Guid Id { get; }

        public string Title { get; set; }

        public int Unit { get; set; }

        public string Identity => $"Id : {Id} ; Title : {Title} ; Unit : {Unit}";
    }
}