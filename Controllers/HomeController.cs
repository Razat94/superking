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
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Departments()
        {
            listOfDepartments dpList = new listOfDepartments();
            dpList.populateToJSON();
            // I created the below function just to see if I can correctly populate a List from a JSON File (which it does).
            dpList.populateDepartmentListFromJSON(); 

            ViewBag.dpList = dpList;
            ViewBag.Title = "Department";
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