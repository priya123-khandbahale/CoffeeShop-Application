namespace CoffeeShop.Models.Interfaces
{
    public interface IProductRepository
    {

        public IEnumerable<Products> GetAllProducts();

        public IEnumerable<Products> GetTrendingProducts();

        public Products? GetProductDetail(int id);
    }
}
