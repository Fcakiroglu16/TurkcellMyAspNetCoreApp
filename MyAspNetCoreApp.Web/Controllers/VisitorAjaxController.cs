using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using MyAspNetCoreApp.Web.Models;
using MyAspNetCoreApp.Web.ViewModels;

namespace MyAspNetCoreApp.Web.Controllers
{
    public class VisitorAjaxController : Controller
    {
        private readonly IMapper _mapper;
        private readonly AppDbContext _context;

        public VisitorAjaxController(IMapper mapper, AppDbContext context)
        {
            _mapper = mapper;
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }


        [HttpPost]
        public IActionResult SaveVisitorComment(VisitorViewModel visitorViewModel)
        {
          
                var visitor = _mapper.Map<Visitor>(visitorViewModel);

                visitor.Created = DateTime.Now;
                _context.Visitors.Add(visitor);

                _context.SaveChanges();
            return Json(new { IsSuccess = "true" });

        
        }

        [HttpGet]
        public IActionResult   VisitorCommentList()
        {
            var visitors = _context.Visitors.OrderByDescending(x=>x.Created).ToList();

            var visitorViewModels = _mapper.Map<List<VisitorViewModel>>(visitors);


            return Json(visitorViewModels);

        }


    }
}
