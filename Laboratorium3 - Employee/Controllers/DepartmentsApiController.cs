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
            return Ok(
                name is null ?
                    context.Departments.ToList()
                :
                    context.Departments
                        .Where(department => department.Name.ToUpper().StartsWith(name.ToUpper()))
                        .ToList()
            );
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
