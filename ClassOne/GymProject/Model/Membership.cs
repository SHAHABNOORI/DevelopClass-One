using System;

namespace GymProject.Model
{
    public class Membership
    {
        public Membership(DateTime registerDate, MembershipTypes memberShipType)
        {
            MembershipId=Guid.NewGuid();
            RegisterDate = registerDate;
            MemberShipType = memberShipType;
        }

        public Guid MembershipId { get; set; }

        public DateTime RegisterDate { get; set; }

        public MembershipTypes MemberShipType { get; set; }
    }
}