using CoffeeShop.Data;
using CoffeeShop.Models.Interfaces;

namespace CoffeeShop.Models.Services
{
    public class ProductRepository : IProductRepository
    {

        private CoffeeShopDbContext dbContext;

        public ProductRepository(CoffeeShopDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public IEnumerable<Products> GetAllProducts()
        {
            return dbContext.Products;
        }

        public Products? GetProductDetail(int id)
        {
            return dbContext.Products.FirstOrDefault(p=> p.Id == id);
        }

        public IEnumerable<Products> GetTrendingProducts()
        {
            return dbContext.Products.Where(P => P.IsTrendingProduct);
        }
    }
}
