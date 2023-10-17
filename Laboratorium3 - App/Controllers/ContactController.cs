using Microsoft.AspNetCore.Mvc;
using Laboratorium3___App.Models;

namespace Laboratorium3___App.Controllers
{
    public class ContactController : Controller
    {
        private static readonly Dictionary<int, Contact> contacts = new Dictionary<int, Contact>();
        private static int id = 1;

        public IActionResult Index()
        {
            return View(contacts);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Contact model)
        {
            if (ModelState.IsValid) // validation of "Contact model"
            {
                model.Id = id++;
                contacts.Add(model.Id, model);
                return RedirectToAction("Index");
            }

            return View(model); // show form again - with errors
        }

        [HttpGet]
        public IActionResult Update(int id)
        {
            return View(contacts[id]);    
        }

        [HttpPost]
        public IActionResult Update(Contact model)
        {
            if (ModelState.IsValid)
            {
                contacts[model.Id] = model;
                return RedirectToAction("Index");
            }

            return View();
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            return View(contacts[id]);
        }

        [HttpPost]
        public IActionResult Delete(Contact model)
        {
            contacts.Remove(model.Id);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Details(int id)
        {
            return View(contacts[id]);
        }
    }
}
