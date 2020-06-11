using System;

namespace DeveloperClass_7.Models
{
    public class Student
    {
        public Student(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
            Id = Guid.NewGuid();
        }

        public Guid Id { get; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Identity => $"Id : {Id} ; First Name : {FirstName} ; Last Name : {LastName}";

        //public string FullName { get { return FirstName + LastName; } }

    }
}