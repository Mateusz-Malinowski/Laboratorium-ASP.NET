using Microsoft.AspNetCore.Mvc;
using Laboratorium3___Employee.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using Laboratorium3___Employee.Services;

namespace Laboratorium3___Employee.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly IEmployeeService _employeeService;
        private readonly IDepartmentService _departmentService;

        public EmployeeController(IEmployeeService employeeService, IDepartmentService departmentService)
        {
            _employeeService = employeeService;
            _departmentService = departmentService;
        }

        public IActionResult Index()
        {
            var employees = _employeeService.FindAll();
            foreach (Employee employee in employees) employee.Department = _departmentService.FindById(employee.DepartmentId);
            return View(employees);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View(new Employee() { DepartmentList = CreateDepartmentsSelectListItem() });
        }

        [HttpPost]
        public IActionResult Create(Employee model)
        {
            if (ModelState.IsValid) // validation of "Employee model"
            {
                _employeeService.Add(model);
                return RedirectToAction("Index");
            }

            model.DepartmentList = CreateDepartmentsSelectListItem();
            return View(model); // show form again - with errors
        }

        [HttpGet]
        public IActionResult Update(int id)
        {
            var employee = _employeeService.FindById(id);
            if (employee is null) return NotFound();
            employee.DepartmentList = CreateDepartmentsSelectListItem();
            return View(employee);
        }

        [HttpPost]
        public IActionResult Update(Employee model)
        {
            if (ModelState.IsValid)
            {
                _employeeService.Update(model);
                return RedirectToAction("Index");
            }

            model.DepartmentList = CreateDepartmentsSelectListItem();
            return View(model);
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var employee = _employeeService.FindById(id);
            if (employee is null) return NotFound();
            return View(employee);
        }

        [HttpPost]
        public IActionResult Delete(Employee model)
        {
            _employeeService.Delete(model.Id);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Details(int id)
        {
            var employee = _employeeService.FindById(id);
            if (employee is null) return NotFound();
            employee.Department = _departmentService.FindById(employee.DepartmentId);
            return View(employee);
        }

        private List<SelectListItem> CreateDepartmentsSelectListItem()
        {
            var items = _employeeService.FindAllDepartments()
                          .Select(e => new SelectListItem()
                          {
                              Text = e.Name,
                              Value = e.Id.ToString()
                          }).ToList();
            items.Add(new SelectListItem() { Text = "Unknown", Value = "" });
            return items;
        }
    }
}
