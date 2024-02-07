using Microsoft.AspNetCore.Mvc;

namespace MVCWebApplication1.Controllers
{
    public class StudentController : Controller
    {
        private static List<Student> Students = new List<Student>()
        {
            new Student {Id = 1, Name = "Youssef"},
            new Student {Id = 2, Name = "Gamil"}
        };
        [HttpGet]
        public JsonResult Get(int id)
        {
            return Json(Students.FirstOrDefault(st => st.Id == id));
        }
        [HttpGet]
        public JsonResult GetAll()
        {
            return Json(Students);
        }
        [HttpPut]
        public void Add([FromBody] Student student)
        {
            Students.Add(student);
        }
        [HttpPost]
        public void Modify([FromBody] Student student)
        {
            Students.RemoveAll(st => st.Id == student.Id);
            Students.Add(student);
        }
        [HttpDelete]
        public void Delete(int id) 
        {
            Students.RemoveAll(st => st.Id == id);
        }

    }

    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }

    }
}
