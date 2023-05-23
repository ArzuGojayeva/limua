using asp.intro.Models;
using Microsoft.AspNetCore.Mvc;

namespace asp.intro.Controllers
{
    public class HomeController : Controller
    {
        List<Student> students = new List<Student>();
        public HomeController()
        {
            students = new List<Student>()
            {
                new Student()
                {
                    Id = 1,
                    Name = "Jale",
                    Surname = "Ekberova",
                    GroupName = "BB204",
                    AvgPoint = 85
                },
                new Student()
                {
                    Id = 2,
                    Name = "Hesim",
                    Surname = "Eyvazov",
                    GroupName = "BB204",
                    AvgPoint = 65
                },
                new Student()
                {
                    Id = 3,
                    Name = "Eli",
                    Surname = "Ekberov",
                    GroupName = "BB204",
                    AvgPoint = 73
                }
            };


        }
            public IActionResult Index()
            {
                return View(students);
            }
    }
}

