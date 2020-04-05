using Microsoft.AspNetCore.Mvc;

namespace MyCourse2.Controllers
{
    public class CoursesController : Controller 
    {
        public IActionResult Index() 
        {
            return View();
        }

        public IActionResult Detail(string id)
        {
            return View();
        }
    }
}