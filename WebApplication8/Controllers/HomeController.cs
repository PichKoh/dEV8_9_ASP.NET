using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApplication8.Models;

namespace WebApplication8.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private static List<Product> products = new List<Product>();

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View(products.Count);
        }

        [HttpPost]
        public IActionResult Index(Product product)
        {
            product.Id = products.Count;
            products.Add(product);
            return View(products.Count);
        }

        [HttpPost]
        public IActionResult ViewProductsAsList()
        {
            return View("Products", products);
        }

        [HttpPost]
        public IActionResult ViewProductsAsTable()
        {
            return View("ProductsTable", products);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}