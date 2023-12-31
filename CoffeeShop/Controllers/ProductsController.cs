using CoffeeShop.Models.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CoffeeShop.Controllers
{
    public class ProductsController : Controller
    {
        private IProductRepository productRepository;
        //  created field (with name productRepository)  as a private interface  

        public ProductsController(IProductRepository productRepository)
        {
            this.productRepository = productRepository;
        }


        public IActionResult Shop()
        {
            return View(productRepository.GetAllProducts());
        }

        public IActionResult Details(int id) 
        { 
          var product = (productRepository.GetProductDetail(id));

            if(product == null) 
            { 
            return NotFound();  
            
            }
            return View(product);
        
        }

    }
}
