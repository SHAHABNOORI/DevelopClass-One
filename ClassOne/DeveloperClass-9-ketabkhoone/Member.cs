using System;
using System.Collections.Generic;

namespace DeveloperClass_9_ketabkhoone
{
    public class Member
    {
        public Member()
        {
            Borrows = new List<Borrow>();
        }

        public Guid MemberId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public List<Borrow> Borrows { get; set; }
    }
}