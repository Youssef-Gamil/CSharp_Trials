using Microsoft.AspNetCore.Mvc;
using RazorViewsTrial.Models;
using System.Diagnostics;

namespace RazorViewsTrial.Controllers
{
    public class CompanyController : Controller
    {
        public static List<Company> CompaniesList = new List<Company>()
        {
            new Company {Id = 1, Name = "Amazon", Url = "http://www.amazon.com"},
            new Company {Id = 2, Name = "Google", Url = "https://www.google.com" },
            new Company {Id = 3, Name = "Yahoo", Url = "https://www.yahoo.com" }
        };

        public ViewResult Details(int id)
        {
            var comp = CompaniesList.First(x => x.Id == id);
            return View(comp);
        }

        public ViewResult Index() 
        {
            return View(CompaniesList);
        }

        [HttpGet]
        public ActionResult Delete(int id)
        {
            CompaniesList.RemoveAll(x => x.Id == id);
            return RedirectToAction("Index", "Company");
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            var comp = CompaniesList.First(c => c.Id == id);
            return View(comp);
        }
        [HttpPost]
        public ActionResult Edit(Company comp)
        {
            CompaniesList.RemoveAll(c => c.Id == comp.Id);
            CompaniesList.Add(comp);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult Create()
        { return View(); }
        [HttpPost]
        public ActionResult Create(Company comp)
        {
            comp.Id = CompaniesList.Max(x => x.Id) + 1;
            CompaniesList.Add(comp);
            return RedirectToAction("Index");
        }
    }

    public class Company
    {
        public int Id { get; set; }
        public string Name { get;  set; }
        public string Url { get;  set; }
    }
}