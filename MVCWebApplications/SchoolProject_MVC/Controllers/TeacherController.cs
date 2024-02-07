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
    }
}
