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
        private readonly IPositionService _positionService;

        public EmployeeController(IEmployeeService employeeService, IDepartmentService departmentService, IPositionService positionService)
        {
            _employeeService = employeeService;
            _departmentService = departmentService;
            _positionService = positionService;
        }

        public IActionResult Index()
        {
            var employees = _employeeService.FindAll();
            foreach (Employee employee in employees)
            {
                employee.Position = _positionService.FindById(employee.PositionId);
                employee.Department = _departmentService.FindById(employee.DepartmentId);
            }
            return View(employees);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View(new Employee() { PositionList = CreatePositionSelectListItems() });
        }

        [HttpPost]
        public IActionResult Create(Employee model)
        {
            if (ModelState.IsValid) // validation of "Employee model"
            {
                _employeeService.Add(model);
                return RedirectToAction("Index");
            }

            model.PositionList = CreatePositionSelectListItems();
            return View(model); // show form again - with errors
        }

        [HttpGet]
        public IActionResult Update(int id)
        {
            var employee = _employeeService.FindById(id);
            if (employee is null) return NotFound();
            employee.PositionList = CreatePositionSelectListItems();
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

            model.PositionList = CreatePositionSelectListItems();
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
            employee.Position = _positionService.FindById(employee.PositionId);
            employee.Department = _departmentService.FindById(employee.DepartmentId);
            return View(employee);
        }

        private List<SelectListItem> CreatePositionSelectListItems()
        {
            var items = _positionService.FindAll()
                          .Select(e => new SelectListItem()
                          {
                              Text = e.Name,
                              Value = e.Id.ToString()
                          }).ToList();
            return items;
        }
    }
}
