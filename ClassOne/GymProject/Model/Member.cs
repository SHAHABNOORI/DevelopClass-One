using System;
using System.Collections.Generic;

namespace GymProject.Model
{
    /// <summary>
    /// عضو
    /// </summary>
    public class Member : Person
    {
        public Member(string melliCode, string firstName, string lastName, string mobileNo) :
            base(melliCode, firstName, lastName, mobileNo)
        {
            MemberId = Guid.NewGuid();
            Traffics = new List<Traffic>();
            Memberships = new List<Membership>();
        }

        /// <summary>
        /// شناسه عضو
        /// </summary>
        public Guid MemberId { get; set; }

        /// <summary>
        /// لیست عضویت های عضو
        /// </summary>
        public List<Membership> Memberships { get; set; }

        /// <summary>
        /// لیست ترددهای عضو
        /// </summary>
        public List<Traffic> Traffics { get; set; }

    }
}