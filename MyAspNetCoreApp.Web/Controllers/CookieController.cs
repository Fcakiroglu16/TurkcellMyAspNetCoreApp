using Microsoft.AspNetCore.Mvc;

namespace MyAspNetCoreApp.Web.Controllers
{
    public class CookieController : Controller
    {
        public IActionResult CookieCreate()
        {

            HttpContext.Response.Cookies.Append("backgorund-color", "red",new CookieOptions() {  Expires= DateTime.Now.AddDays(2)});
            return View();
        }


        public IActionResult CookieRead()
        {

         var bgcolor=   HttpContext.Request.Cookies["backgorund-color"];


            ViewBag.bgcolor = bgcolor;
            return View();



        }
    }
}
