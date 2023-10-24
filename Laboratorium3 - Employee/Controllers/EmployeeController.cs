using Microsoft.AspNetCore.Mvc;
using Laboratorium3___Employee.Models;

namespace Laboratorium3___Employee.Controllers
{
    public class EmployeeController : Controller
    {
        private static readonly Dictionary<int, Employee> employees = new Dictionary<int, Employee>();
        private static int id = 1;

        public IActionResult Index()
        {
            return View(employees.Values.ToList());
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Employee model)
        {
            if (ModelState.IsValid) // validation of "Employee model"
            {
                model.Id = id++;
                employees.Add(model.Id, model);
                return RedirectToAction("Index");
            }

            return View(model); // show form again - with errors
        }

        [HttpGet]
        public IActionResult Update(int id)
        {
            return View(employees[id]);
        }

        [HttpPost]
        public IActionResult Update(Employee model)
        {
            if (ModelState.IsValid)
            {
                employees[model.Id] = model;
                return RedirectToAction("Index");
            }

            return View();
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            return View(employees[id]);
        }

        [HttpPost]
        public IActionResult Delete(Employee model)
        {
            employees.Remove(model.Id);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Details(int id)
        {
            return View(employees[id]);
        }
    }
}
