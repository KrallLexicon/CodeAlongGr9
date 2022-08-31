using CodeAlongGr9.Data;
using Microsoft.AspNetCore.Mvc;

namespace CodeAlongGr9.Controllers
{
    public class CarsController : Controller
    {

        readonly ApplicationDbContext _context;

        public CarsController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View(_context.Cars.ToList());
        }
    }
}
