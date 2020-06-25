using System;
using System.Collections.Generic;

namespace DeveloperClass_9_ketabkhoone
{
    class Program
    {
        static void Main(string[] args)
        {
            Member memberOne = new Member()
            {
                FirstName = "Shahab",
                LastName = "Noori Goodarzi",
                MemberId = Guid.NewGuid()
            };

            Book bookOne = new Book()
            {
                Title = "Shahnameh",
                Isbn = "1212gf12",
                BookId = Guid.NewGuid()
            };

            Book bookTwo = new Book()
            {
                Title = "Hezaro yek shab",
                Isbn = "1212gf12",
                BookId = Guid.NewGuid()
            };

            Book bookThree = new Book()
            {
                Title = "nemoneh",
                Isbn = "1212gf12",
                BookId = Guid.NewGuid()
            };

            MakeBorrow(bookOne, memberOne);
            MakeBorrow(bookThree, memberOne);
            MakeBorrow(bookTwo, memberOne);
        }

        private static void MakeBorrow(Book book, Member member)
        {
            if (member.Borrows.Count < 2)
            {
                Borrow borrowOne = new Borrow()
                {
                    Book = book,
                    BorrowDate = DateTime.Now,
                    BorrowId = Guid.NewGuid()
                };
                member.Borrows.Add(borrowOne);
            }
            else
            {
                Console.WriteLine($"Shoma dar hale hazer 2 ketab be amanat bordeid  va nemitavnid ketabe {book.Title} amanat begirid");
            }
        }
    }
}
