namespace DeveloperClass_6
{
    public class Author
    {
        public Author()
        {
            // Memory Allocate
            Books = new Book[10];
        }

        public Author(int length)
        {
            Books = new Book[length];
        }
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public Book Book { get; set; }

        public Book[] Books { get; set; }
    }
}