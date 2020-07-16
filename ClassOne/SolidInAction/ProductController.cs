namespace SolidInAction
{
    public class ProductController
    {
        private readonly ApplicationDbContext _dbContext;

        public ProductController(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void Put(Product product)
        {
            _dbContext.Add(product);
        }
    }
}