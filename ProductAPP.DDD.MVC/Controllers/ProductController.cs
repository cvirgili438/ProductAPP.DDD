using Microsoft.AspNetCore.Mvc;
using ProductAPP.DDD.Domain.Entities;
using ProductAPP.DDD.Domain.Value_Objects.Product;
using ProductAPP.DDD.MVC.ApplicationServices;
using ProductAPP.DDD.MVC.Commands;

namespace ProductAPP.DDD.MVC.Controllers
{
    public class ProductController : Controller
    {
        private readonly ProductServices productServices;

        public ProductController(ProductServices productServices)
        {
            this.productServices = productServices;
        }
        public async Task<IActionResult> Index()
        {
            var products = await productServices.GetAllProducts();
            return View(products);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create([Bind("Id,Name,Price,Stock,Description")] CreateProductCommand product) 
        {
            CreateProductCommand newProduct = new CreateProductCommand(product.Name, product.Price, product.Stock, product.Description);
            await productServices.HandleCommand(newProduct);
            return RedirectToAction("Index","Product");
        }
    }
}
