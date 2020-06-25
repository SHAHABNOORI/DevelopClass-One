using System;

namespace DeveloperClass_9
{
    public class Person
    {
        public Guid PersonId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public Person()
        {

        }

        public Person(Guid id)
        {
            PersonId = id;
        }

        public Person(Guid id, string firstName) : this(id)
        {
            FirstName = firstName;
        }

        public Person(Guid id, string firstName, string lastName) : this(id, firstName)
        {
            LastName = lastName;
        }
    }
}