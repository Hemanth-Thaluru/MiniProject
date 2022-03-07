using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace College_Portal.Controllers
{
    public class DepartmentsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult CSE()
        {
            return View();
        }
        public IActionResult ECE()
        {
            return View();
        }
        public IActionResult MECH()
        {
            return View();
        }
        public IActionResult EEE()
        {
            return View();
        }
        public IActionResult CIVIL()
        {
            return View();
        }
    }
}
