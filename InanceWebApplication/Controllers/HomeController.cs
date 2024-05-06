using InanceWebApplication.DAL;
using InanceWebApplication.Models;
using InanceWebApplication.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace InanceWebApplication.Controllers
{
    public class HomeController : Controller
    {
        AppDbContext _AppDbContext;
        public HomeController(AppDbContext dbContext)
        {
            _AppDbContext = dbContext;
        }
        public IActionResult Index()
        {
           List<Comments> comments = _AppDbContext.Comments.ToList();
            List<Services> services = _AppDbContext.Services.ToList();
            HomeVM homeVM = new HomeVM();
            homeVM.Comments = comments;
            homeVM.Services = services;
          
           
            
            return View(homeVM);
        }
        public IActionResult About()
        {
            return View();
        }
        public IActionResult Contact()
        {
            return View();
        }
        public IActionResult Service()
        {
            List<Services> services = _AppDbContext.Services.ToList();
            HomeVM homeVM = new HomeVM();
            homeVM.Services = services;
            return View(homeVM);
        }

    }
}
