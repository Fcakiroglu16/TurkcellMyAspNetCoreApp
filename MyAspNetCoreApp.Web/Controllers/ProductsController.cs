using Microsoft.AspNetCore.Mvc;
using MyAspNetCoreApp.Web.Models;

namespace MyAspNetCoreApp.Web.Controllers
{
    public class ProductsController : Controller
    {

        private readonly ProductRepository _productRepository;
        public ProductsController()
        {
            _productRepository =new  ProductRepository();

          

        }
        public IActionResult Index()
        {
            var products = _productRepository.GetAll();

            return View(products);
        }

        public IActionResult Remove(int id)
        {

            _productRepository.Remove(id);
            return RedirectToAction("Index");

        }

        public IActionResult Add()
        {

            return View();
        }

        public IActionResult Update(int id)
        {

            return View();
        }
    }
}
