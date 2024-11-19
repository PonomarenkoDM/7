using Microsoft.AspNetCore.Mvc;

namespace WebApplication3.Controllers
{
    public class HomeController : Controller
    {
        [Route("/")]
        public IActionResult Index()
        {
            return View();
        }
        [Route("/result")]
        public IActionResult Result(string [] Subjects,string [] Assessments, string [] colors)
        {
            ViewBag.Subjects = Subjects;
            ViewBag.Assessments = Assessments;
            ViewBag.Colors = colors;
            return View();
        }
    }
}
