namespace GymProject.Model
{
    public class Person
    {
        public Person(string melliCode, string firstName, string lastName, string mobileNo)
        {
            MelliCode = melliCode;
            FirstName = firstName;
            LastName = lastName;
            MobileNo = mobileNo;
        }

        public string MelliCode { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string MobileNo { get; set; }

        public string Address { get; set; }
    }
}