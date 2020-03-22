using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Nothing.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class TestAreasController : Controller
    {
        public IActionResult TestAreas()
        {
            return View();
        }

        public IActionResult Next()
        {
            return RedirectToAction("Index", "DoneAreas", new { Area = "Admin" });
        }
    }
}