using System;
using System.Reflection.Metadata;

namespace DeveloperClass_7.Models
{
    public class Teacher
    {
        public Teacher(string firstName, string lastName)
        {
            Id = Guid.NewGuid();
            FirstName = firstName;
            LastName = lastName;
        }
        public Guid Id { get; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Identity => $"Id : {Id} ; First Name :  {FirstName} ; Last Name : {LastName}";
    }
}