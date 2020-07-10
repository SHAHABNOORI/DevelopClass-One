using System;

namespace TuplesInAction
{
    class Program
    {
        static void Main(string[] args)
        {
            //UsingOutAndRef();
            //Tuple<Guid, string, string> person = new Tuple<Guid, string, string>(Guid.NewGuid(), "Shahab", "Noori Goodarzi");
            //var person = Tuple.Create(Guid.NewGuid(), "Shahab", "Noori Goodarzi");

            var person = GetPerson();
            Console.WriteLine(person.Item1);
            Console.WriteLine(person.Item2);
            Console.WriteLine(person.Item3);


            var personTwo = GetPersonVersionTwo();
            Console.WriteLine(personTwo.id);
            Console.WriteLine(personTwo.firstName);
            Console.WriteLine(personTwo.lastName);
        }

        private static void UsingOutAndRef()
        {
            int x = 1;
            int y = 2;
            int myResult;
            int myTest;
            Sum(ref x, ref y, out myResult, out myTest);
            Console.WriteLine(myResult);
            Console.WriteLine(myTest);
        }

        static (Guid id, string firstName, string lastName) GetPersonVersionTwo()
        {
            (Guid id, string firstName, string lastName) person = (Guid.NewGuid(), "Shahab", "Noori");
            return person;
        }

        static Tuple<int, string, string> GetPerson()
        {
            return Tuple.Create(1, "Shahab", "Noori");
        }

        static void Sum(ref int numberOne, ref int numberTwo, out int result, out int test)
        {
            numberOne = 20;
            numberTwo = 30;
            result = numberOne + numberTwo;
            test = 25;
        }
    }
}
