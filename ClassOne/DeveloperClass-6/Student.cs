using System;

namespace DeveloperClass_6
{
    public class Student
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string MobileNumber { get; set; }

        public byte Age
        {
            get => Age;
            set
            {
                if (value > 0)
                {
                    Age = value;
                }
                else
                {
                    Console.WriteLine("You most set age above the zero");
                }
            }
        }

        public string Address { get;  }


    }
}

//Read/Write Property
//Readonly Property
//WriteOnly Property

