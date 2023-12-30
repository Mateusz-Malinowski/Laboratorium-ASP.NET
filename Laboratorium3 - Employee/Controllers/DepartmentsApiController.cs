using Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Laboratorium3___App.Controllers
{
    [Route("api/departments")]
    [ApiController]
    public class DepartmentsApiController : ControllerBase
    {
        private readonly AppDbContext context;

        public DepartmentsApiController(AppDbContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public IActionResult GetDepartmentsByName(string? name)
        {
            if (name is null) return Ok(context.Departments.ToList());

            var departmentsMatchingName = context.Departments
                .Where(department => department.Name.ToUpper().Contains(name.ToUpper()))
                .ToList();

            return Ok(departmentsMatchingName);
        }

        [Route("{id}")]
        [HttpGet]
        public IActionResult GetById(int id)
        {
            var entity = context.Departments.Find(id);
            if (entity is null) return NotFound();

            return Ok(entity);
        }
    }
}
