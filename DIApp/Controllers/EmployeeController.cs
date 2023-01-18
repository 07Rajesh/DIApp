using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DIApp.Models;
namespace DIApp.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly IEmployeeService service;

        //     EmployeeService service = new EmployeeService();

        public EmployeeController(IEmployeeService employeeService)
        {
            this.service = employeeService;
        }
        public IActionResult Index()
        {
            var emps = service.GetEmployees();
            return View(emps);
        }
        public IActionResult AddEmployee()
        {
            return View();
        } 
        [HttpPost]
        public IActionResult AddEmployee(Employee employee)
        { 
            service.AddEmployee(employee);
            return RedirectToAction("Index");
        }
    }
}
