using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using mvcapp.Models;

using departmentPage.Models;
// NOTE ^^ THE ABOVE MODEL IS PHYSICALLY INCLUDED

namespace mvcapp.Controllers
{
    public class HomeController : Controller
    {
        Departm yomama = new Departm();
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Departments()
        {
            Departm Produce = new Departm();
            Produce.setProduce();

            ViewBag.Produce = Produce;
            return View();
        }

        public IActionResult contactUs()
        {
            return View();
        }

        public IActionResult aboutUs()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}