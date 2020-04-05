using Microsoft.AspNetCore.Mvc;

namespace MyCourse2.Controllers
{
    public class CoursesController : Controller 
    {
        public IActionResult Index() 
        {
            return Content("Sono Index");
        }

        public IActionResult Detail(string id)
        {
            return Content($"Sono Detail, e ho ricevuto l' id {id}");
        }
    }
}