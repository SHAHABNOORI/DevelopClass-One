using System;

namespace DeveloperClass_9_ketabkhoone
{
    public class Borrow
    {
        public Guid BorrowId { get; set; }

        public Book Book { get; set; }

        public DateTime BorrowDate { get; set; }
    }
}