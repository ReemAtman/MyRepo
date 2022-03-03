using CoreApp.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreApp.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Index()
        {
            return View(Repository.AllEmpoyees);
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Employee employee)
        {
            Repository.Create(employee);
            return View("Thanks", employee);
        }
        public IActionResult Update(string empName)
        {
            ViewBag.oldEmpName = empName;
            return View(Repository.AllEmpoyees.Where(e => e.Name == empName).FirstOrDefault());
        }

        [HttpPost]
        public IActionResult Update(Employee employee, string empName)
        {
            Repository.AllEmpoyees.Where(e => e.Name == empName).FirstOrDefault()
                .Age = employee.Age;
            Repository.AllEmpoyees.Where(e => e.Name == empName).FirstOrDefault()
                .Salary = employee.Salary;
            Repository.AllEmpoyees.Where(e => e.Name == empName).FirstOrDefault()
                .Department = employee.Department;
            Repository.AllEmpoyees.Where(e => e.Name == empName).FirstOrDefault()
                .Sex = employee.Sex;
            Repository.AllEmpoyees.Where(e => e.Name == empName).FirstOrDefault()
                .Name = employee.Name;

            return RedirectToAction("Index");
        }

        public IActionResult Delete(string empName)
        {
            Repository.DeleteEmp(empName);
            return RedirectToAction("Index");
        }
    }
}
