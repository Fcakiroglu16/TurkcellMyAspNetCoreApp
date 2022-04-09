using Microsoft.AspNetCore.Mvc;
using MyAspNetCoreApp.Web.Helpers;
using MyAspNetCoreApp.Web.Models;

namespace MyAspNetCoreApp.Web.Controllers
{
    public class ProductsController : Controller
    {

        private AppDbContext _context;

       

        private readonly ProductRepository _productRepository;
        public ProductsController(AppDbContext context)
        {

          
            _productRepository =new  ProductRepository();
         
            _context = context;

           
         


        }


        public IActionResult Index()
        {

        

            var products = _context.Products.ToList();

          
       
            return View(products);
        }

        public IActionResult Remove(int id)
        {
            var product = _context.Products.Find(id);

            _context.Products.Remove(product);

            _context.SaveChanges();
            return RedirectToAction("Index");

        }
        [HttpGet]
        public IActionResult Add()
        {

         

            ViewBag.Expire = new Dictionary<string, int>()
            {
                { "1 Ay",1 },
                 { "3 Ay",3 },
                 { "6 Ay",6 },
                 { "12 Ay",12 }
            };




            return View();
        }

        [HttpPost]
        public IActionResult Add(Product newProduct)
        {

            _context.Products.Add(newProduct);
            _context.SaveChanges();

            TempData["status"] = "Ürün başarıyla eklendi.";
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Update(int id)
        {

            var product = _context.Products.Find(id);

            return View(product);
        }

        [HttpPost]
        public IActionResult Update(Product updateProduct,int productId,string type)
        {

            updateProduct.Id = productId;
            _context.Products.Update(updateProduct);
            _context.SaveChanges();

            TempData["status"] = "Ürün başarıyla güncellendi.";
            return RedirectToAction("Index");
        }

       
        [Route("[controller]/[action]/page/{page}/pagesize/{pagesize}")]
        [HttpGet]
        public IActionResult   GetData(int page,int pageSize)
        {


            return View();
        }
    }
}
