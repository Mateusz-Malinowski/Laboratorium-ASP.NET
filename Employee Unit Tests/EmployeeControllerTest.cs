using Laboratorium3___Employee.Controllers;
using Laboratorium3___Employee.Services;
using Laboratorium3___Employee.Models;

namespace Employee_Unit_Tests
{
    public class EmployeeControllerTest
    {
        private EmployeeController _controller;
        private IEmployeeService _service;

        public ContactControllerTest()
        {
            _service = new EFEmployeeService();
            _service.Add(new Employee() { Id = 1 });
            _service.Add(new Employee() { Id = 2 });
            _controller = new EmployeeController(_service, new EFDepartmentService(), new EFPositionService());
        }

        [Fact]
        public void IndexShowsAllEmployeesWithCorrectData()
        {

        }
    }
}