using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Nothing.Web.Controllers
{
    public class TestThemeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}