using CodeAlongGr9.Data;
using CodeAlongGr9.Models;
using Microsoft.AspNetCore.Mvc;

namespace CodeAlongGr9.Controllers
{
    public class PeopleController : Controller
    {
        readonly ApplicationDbContext _context;

        public PeopleController(ApplicationDbContext context)
        {
            _context = context;
        }

         public IActionResult Index()
        {
            List<Person> listOfPeople = _context.People.ToList();
            
            return View(listOfPeople);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Person person)
        {
            if(ModelState.IsValid)
            {
                _context.People.Add(person);
                _context.SaveChanges();
            }
            return RedirectToAction("Index");
        }

        public IActionResult Edit(string ssn)
        {
            var person = _context.People.FirstOrDefault(x => x.SSN == ssn);
            return View(person);
        }
        [HttpPost]
        public IActionResult Edit(Person person)
        {
            _context.Update(person);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }

        public IActionResult Delete(string ssn)
        {
            var person = _context.People.FirstOrDefault(x => x.SSN == ssn);

            _context.People.Remove(person);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}
