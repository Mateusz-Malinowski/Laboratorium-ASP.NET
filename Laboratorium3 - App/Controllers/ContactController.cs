using Microsoft.AspNetCore.Mvc;
using Laboratorium3___App.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Authorization;

namespace Laboratorium3___App.Controllers
{
    [Authorize]
    public class ContactController : Controller
    {
        private readonly IContactService _contactService;

        public ContactController(IContactService contactService)
        {
            _contactService = contactService;
        }

        [AllowAnonymous]
        public IActionResult Index()
        {
            return View(_contactService.FindAll());
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View(new Contact() { OrganizationList = CreateSelectListItem() });
        }

        [HttpPost]
        public IActionResult Create(Contact model)
        {
            if (ModelState.IsValid) // validation of "Contact model"
            {
                _contactService.Add(model);
                return RedirectToAction("Index");
            }

            model.OrganizationList = CreateSelectListItem();
            return View(model); // show form again - with errors
        }

        [HttpGet]
        public IActionResult Update(int id)
        {
            return View(_contactService.FindById(id));    
        }

        [HttpPost]
        public IActionResult Update(Contact model)
        {
            if (ModelState.IsValid)
            {
                _contactService.Update(model);
                return RedirectToAction("Index");
            }

            return View();
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            return View(_contactService.FindById(id));
        }

        [HttpPost]
        public IActionResult Delete(Contact model)
        {
            _contactService.Delete(model.Id);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Details(int id)
        {
            return View(_contactService.FindById(id));
        }

        private List<SelectListItem> CreateSelectListItem()
        {
            var items = _contactService.FindAllOrganizations()
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
