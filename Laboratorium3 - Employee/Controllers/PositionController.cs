using Microsoft.AspNetCore.Mvc;
using Laboratorium3___Employee.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using Laboratorium3___Employee.Services;
using Microsoft.AspNetCore.Authorization;
using System.Data;

namespace Laboratorium3___Employee.Controllers
{
    [Authorize(Roles = "admin")]
    public class PositionController : Controller
    {
        private readonly IPositionService _positionService;

        public PositionController(IPositionService positionService)
        {
            _positionService = positionService;
        }

        [AllowAnonymous]
        public IActionResult Index(int page = 1, int size = 5)
        {
            return View(_positionService.FindPage(page, size));
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Position model)
        {
            if (ModelState.IsValid) // validation of "Position model"
            {
                _positionService.Add(model);
                return RedirectToAction("Index");
            }

            return View(model); // show form again - with errors
        }

        [HttpGet]
        public IActionResult Update(int id)
        {
            var position = _positionService.FindById(id);
            if (position is null) return NotFound();
            return View(position);
        }

        [HttpPost]
        public IActionResult Update(Position model)
        {
            if (ModelState.IsValid)
            {
                _positionService.Update(model);
                return RedirectToAction("Index");
            }

            return View(model);
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var position = _positionService.FindById(id);
            if (position is null) return NotFound();
            return View(position);
        }

        [HttpPost]
        public IActionResult Delete(Position model)
        {
            _positionService.Delete(model.Id);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Details(int id)
        {
            var position = _positionService.FindById(id);
            if (position is null) return NotFound();
            return View(position);
        }
    }
}
