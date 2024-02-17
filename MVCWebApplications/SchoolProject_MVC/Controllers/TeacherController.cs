using Microsoft.AspNetCore.Mvc;
using SchoolProject_MVC.Models;

namespace SchoolProject_MVC.Controllers
{
    public class TeacherController : Controller
    {
        private static List<Teacher> Teachers = new List<Teacher>()
        {
            new Teacher {Id = 1, Name ="Youssef Gamil", BlogUrl="http://youssefgamil.com", DOB=DateTime.Now.AddYears(-28), Email="youssef@yahoo.com", NationalId="12345678912345", Password="ABCDF123", PhoneNumber="01001234567", Salary=5000}
        };
        public IActionResult Index()
        {
            return View(Teachers);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Teacher tech)
        { 
            if(ModelState.IsValid) //server side validation
            {
                tech.Id = Teachers.Max(x => x.Id) + 1;
                Teachers.Add(tech);
                return RedirectToAction("Index");
            }
            else
            {
                return View(tech);
            }
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            var tech = Teachers.First(x => x.Id == id);
            return View(tech);
        }
        [HttpPost]
        public IActionResult Edit(Teacher t)
        {
            if (ModelState.IsValid)//server side validation
            {
                Teachers.RemoveAll(x => x.Id == t.Id);
                Teachers.Add(t);
                return RedirectToAction("Index");
            }
            else
            {
                return View(t);
            }
        }
        private IActionResult view(string v)
        {
            throw new NotImplementedException();
        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            Teachers.RemoveAll(x => x.Id == id);
            return RedirectToAction("Index");
        }
    }
}
