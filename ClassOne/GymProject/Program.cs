using System;
using GymProject.Model;

namespace GymProject
{
    class Program
    {
        static void Main(string[] args)
        {
            var registeredMember = Register("56536521", "Shahab", "Noori Goodarzi", "09359167820");

            AddMembership(registeredMember, DateTime.Now, MembershipTypes.Silver);
            AddTranferToMember(registeredMember, new Traffic(DateTime.Now, TrafficType.Enter));
            AddTranferToMember(registeredMember, new Traffic(DateTime.Now.AddHours(2), TrafficType.Exit));
        }

        private static void AddTranferToMember(Member member, Traffic traffic)
        {
            member.Traffics.Add(traffic);
            if (traffic.TrafficType == TrafficType.Enter)
            {
                Console.WriteLine($"{member.FirstName} {member.LastName} Enter in {traffic.DateTime}");
                Console.WriteLine("Wellcome to our gym");
            }
            else
            {
                Console.WriteLine($"{member.FirstName} {member.LastName} Exit in {traffic.DateTime}");
                Console.WriteLine("Good Bye");
            }
        }

        private static Member Register(string melliCode, string firstName, string lastName, string mobileNo)
        {
            Member memberOne = new Member(melliCode, firstName, lastName, mobileNo);
            Console.WriteLine($"{firstName} {lastName} has been Registered");
            return memberOne;
        }

        private static void AddMembership(Member member, DateTime registerDate, MembershipTypes memberShipType)
        {
            member.Memberships.Add(new Membership(registerDate, memberShipType));
            Console.WriteLine($"{member.FirstName} {member.LastName}" +
                              $" has membership of type {memberShipType} from {registerDate} to {registerDate.AddMonths(1)}");
        }
    }
}
