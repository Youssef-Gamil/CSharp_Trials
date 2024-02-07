using Microsoft.AspNetCore.Mvc;
using MVCWebApplication1.Models;
using System.Diagnostics;

namespace MVCWebApplication1.Controllers
{
    [MyActionFilter]
    public class WheatherController : Controller
    {
        public List<Wheather> WheatherList = new List<Wheather>()
        {
            new Wheather {Country = "Egypt", City = "Cairo", Degree = 22 },
            new Wheather {Country = "Egypt", City = "Alex", Degree = 18}
        };
        [HttpGet] //dah kda sha8al k action selector
        public int GetWheather(string country, string city)
        {
            return WheatherList.First(wth => wth.Country.ToLower() == country.ToLower()
            && wth.City.ToLower() == city.ToLower()).Degree;
        }
        [HttpPost]
        public int GetWheather(string country)
        {
            return WheatherList.First(wth => wth.Country.ToLower() == country.ToLower()).Degree;
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }

    public class Wheather
    {
        public string Country { get; internal set; }
        public string City { get; internal set; }
        public int Degree { get; internal set; }
    }

}
