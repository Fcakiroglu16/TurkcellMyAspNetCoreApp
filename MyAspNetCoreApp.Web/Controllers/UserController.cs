using Microsoft.AspNetCore.Mvc;

namespace MyAspNetCoreApp.Web.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
