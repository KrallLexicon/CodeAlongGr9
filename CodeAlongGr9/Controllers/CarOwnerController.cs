using CodeAlongGr9.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace CodeAlongGr9.Controllers
{
    public class CarOwnerController : Controller
    {
        readonly ApplicationDbContext _context;

        public CarOwnerController(ApplicationDbContext context)
        {
            _context = context; 
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult AddOwnerToCar()
        {
            ViewBag.People = new SelectList(_context.People, "SSN", "Name");
            ViewBag.Cars = new SelectList(_context.Cars, "RegNumber", "RegNumber");
            return View();
        }
        [HttpPost]
        public IActionResult AddOwnerToCar(string ssn, string regnumber)
        {
            var person = _context.People.FirstOrDefault(x => x.SSN == ssn);
            var car = _context.Cars.FirstOrDefault(x => x.RegNumber == regnumber);

            person.Cars.Add(car);

            _context.SaveChanges(); 

            return RedirectToAction("Index");
        }
    }
}
