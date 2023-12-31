using Microsoft.AspNetCore.Mvc;
using Laboratorium3___Employee.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using Laboratorium3___Employee.Services;
using Microsoft.AspNetCore.Authorization;
using System.Data;

namespace Laboratorium3___Employee.Controllers
{
    [Authorize(Roles = "admin")]
    public class DepartmentController : Controller
    {
        private readonly IDepartmentService _departmentService;

        public DepartmentController(IDepartmentService departmentService)
        {
            _departmentService = departmentService;
        }

        [AllowAnonymous]
        public IActionResult Index(int page = 1, int size = 5)
        {
            return View(_departmentService.FindPage(page, size));
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Department model)
        {
            if (ModelState.IsValid) // validation of "Department model"
            {
                _departmentService.Add(model);
                return RedirectToAction("Index");
            }

            return View(model); // show form again - with errors
        }

        [HttpGet]
        public IActionResult Update(int id)
        {
            var department = _departmentService.FindById(id);
            if (department is null) return NotFound();
            return View(department);
        }

        [HttpPost]
        public IActionResult Update(Department model)
        {
            if (ModelState.IsValid)
            {
                _departmentService.Update(model);
                return RedirectToAction("Index");
            }

            return View(model);
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var department = _departmentService.FindById(id);
            if (department is null) return NotFound();
            return View(department);
        }

        [HttpPost]
        public IActionResult Delete(Department model)
        {
            _departmentService.Delete(model.Id);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Details(int id)
        {
            var department = _departmentService.FindById(id);
            if (department is null) return NotFound();
            return View(department);
        }
    }
}
