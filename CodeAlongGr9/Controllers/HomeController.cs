using Microsoft.AspNetCore.Mvc;

namespace CodeAlongGr9.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Test()
        {
            return View(); 
        }
    }
}
