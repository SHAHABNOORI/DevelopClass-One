using System;

namespace SolidInAction
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductController controller = new ProductController(new ApplicationDbContext(/*"-----"*/));
            controller.Put(new Product()
            {
                Id = Guid.NewGuid(),
                Name = "Pofak"
            });
        }
    }
}
