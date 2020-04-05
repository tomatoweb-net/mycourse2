using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using MyCourse2.Models.Services.Application;
using MyCourse2.Models.ViewModels;

namespace MyCourse2.Controllers
{
    public class CoursesController : Controller 
    {
        public IActionResult Index() 
        {
            var courseService = new CourseService();
            List<CourseViewModels> courses = courseService.getServices();
            return View(courses);
        }

        public IActionResult Detail(string id)
        {
            return View();
        }
    }
}