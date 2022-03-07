using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace College_Portal.Controllers
{
    public class AcademicsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Faculty()
        {
            return View();
        }
        public IActionResult Results()
        {
            return View();
        }
        public IActionResult Syllabus()
        {
            return View();
        }
        public IActionResult Timetable()
        {
            return View();
        }
    }
}
