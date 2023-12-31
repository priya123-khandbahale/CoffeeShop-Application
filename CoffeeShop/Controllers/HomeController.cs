using CoffeeShop.Models.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CoffeeShop.Controllers
{
    public class HomeController : Controller
    {
        private IProductRepository ProductRepository;

        public HomeController(IProductRepository productRepository)
        {
            this.ProductRepository = productRepository;
        }
        public IActionResult Index()
        {
            return View(ProductRepository.GetTrendingProducts());
            
        }
    }
}
