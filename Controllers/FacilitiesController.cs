using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace College_Portal.Controllers
{
    public class FacilitiesController : Controller
    {
        public IActionResult GreenCampus()
        {
            return View();
        }
        public IActionResult Hostel()
        {
            return View();
        }
    }
}
