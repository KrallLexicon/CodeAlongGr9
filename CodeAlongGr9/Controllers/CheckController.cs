using CodeAlongGr9.Models;
using Microsoft.AspNetCore.Mvc;

namespace CodeAlongGr9.Controllers
{
    public class CheckController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        //GET
        public IActionResult CheckAge()
        {
            return View(); 
        }
        [HttpPost]
        public IActionResult CheckAge(int age)
        {
            ViewBag.Message = CheckModel.CheckAge(age);
            return View();
        }

        public IActionResult SetSession()
        {
            return View(); 
        }

        [HttpPost]
        public IActionResult SetSession(string input)
        {
            if (input != null)
            {
                CookieOptions cookieOptions = new CookieOptions();
                cookieOptions.Expires = DateTime.Now.AddMinutes(5);

                HttpContext.Session.SetString("session", input);
                HttpContext.Response.Cookies.Append("cookie", input, cookieOptions);
                ViewBag.Message = "Session has been set!";
            }
            //else
            //    ViewBag.Message = "Nothing was saved to the session!";

            return View(); 
        }

        public IActionResult GetSession()
        {
            ViewBag.SessionMessage = HttpContext.Session.GetString("session");
            ViewBag.CookieMessage = HttpContext.Request.Cookies["cookie"];
            return View();
        }

    }
}
