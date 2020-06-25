using System;

namespace DeveloperClass_9
{
    public class Student
    {
        private Guid _studentId;

        public Student()
        {
            _studentId = Guid.NewGuid();
        }

        private string _firstName;

        public string LastName;

        public string Addrress { get; set; }



        private int _age;

        public int Age
        {
            get => _age;
            set
            {
                if (value <= 0)
                    Console.WriteLine("Age under 1");

                if (value > 120)
                    Console.WriteLine("Age over 120");

                _age = value;
            }
        }



        //public string GetFullData()
        //{
        //    return $"Id : {StudentId} , First Name : {FirstName} , Last Name : {LastName}";
        //}

        public string GetFullData() => $"Id : {_studentId} , First Name : {_firstName} , Last Name : {LastName} ,Age : {Age}";

        //public void SetFirstName(string firstName)
        //{
        //    _firstName = firstName;
        //}

        public void SetFirstName(string firstName) => _firstName = firstName;

        //public string GetFirstName(string firstName)
        //{
        //    return _firstName;
        //}

        public string GetFirstName(string firstName) => _firstName;
    }
}
