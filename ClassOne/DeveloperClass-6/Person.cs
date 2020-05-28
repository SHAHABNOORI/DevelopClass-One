using System;

namespace DeveloperClass_6
{
    public class Person
    {
        //public Person()
        //{

        //}
        public Person(int id, string firstName, string lastName, string mobileNumber)
        {
            _id = id;
            _firstName = firstName;
            _lastName = lastName;
            _mobileNumber = mobileNumber;
        }

        public void PrintPerson()
        {
            Console.WriteLine($"{_id} {_firstName} {_lastName} {_mobileNumber}");
        }

        private int _id;

        private string _firstName;

        private string _lastName;

        private string _mobileNumber;
    }
}

//parameterless Default Constructor
