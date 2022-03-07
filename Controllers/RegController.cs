using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace College_Portal.Controllers
{
    public class RegController : Controller
    {
        public IActionResult CSEReg()
        {
            return View();
        }
        public IActionResult ECEReg()
        {
            return View();
        }
        public IActionResult MECHReg()
        {
            return View();
        }
    }
}
