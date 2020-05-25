using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using mvcapp.Models;

using departmentPage.Models;
// NOTE ^^ THE ABOVE MODEL IS PHYSICALLY INCLUDED
using employeePage.Models;
using contactUs.Models;

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
            // dpList.populateToJSON(); // Write to JSON
            dpList.populateDepartmentListFromJSON(); // Read from JSON

            ViewBag.dpList = dpList;
            ViewBag.Title = "Department";
            return View();
        }

        public IActionResult contactUs()
        {
            return View(new contactUsModel());
        }

        [HttpPost]
        public IActionResult contactUs(contactUsModel model)
        {
            string data;
            data = $"Hello {model.fullName}";
            data = data + $"\nHere's your data: \n";
            
            data = data + $"\nE-mail: {model.email}";
            data = data + $"\nPhone Number: {model.phone}";
            data = data + $"\nSubject: {model.subject}";
            data = data + $"\nMessage: {model.message}";
            return Content(data);
            /* 
            ViewBag.modelData = model;
            ViewBag.Message = "Success: Value will be inserted into database";
            return View();
            */
        }

        public IActionResult aboutUs()
        {
            return View();
        }

        public IActionResult employee()
        {
            EmployeeList employeesOfTheMonth = new EmployeeList();
            // employeesOfTheMonth.populateToXML(); // Write to XML
            employeesOfTheMonth.populateFromXML(); // Read from XML
            
            ViewBag.employeesOfTheMonth = employeesOfTheMonth;
            ViewBag.Title = "Employees!";
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}