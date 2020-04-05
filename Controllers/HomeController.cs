using Microsoft.AspNetCore.Mvc;

namespace MyCourse2.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        
    }
}