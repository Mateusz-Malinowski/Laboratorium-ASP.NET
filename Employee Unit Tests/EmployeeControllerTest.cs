using Laboratorium3___Employee.Controllers;
using Laboratorium3___Employee.Services;
using Laboratorium3___Employee.Models;
using Microsoft.AspNetCore.Mvc;
using Data;
using Data.Models;
using Data.Entities;
using Moq;
using Xunit.Abstractions;

namespace Employee_Unit_Tests
{
    public class EmployeeControllerTest
    {
        private Mock<AppDbContext> _appDbContextMock;
        private EmployeeController _employeeController;
        private IEmployeeService _employeeService;

        public EmployeeControllerTest()
        {
            _appDbContextMock = new Mock<AppDbContext>();

            var positions = new List<PositionEntity>()
            {
                new PositionEntity() { Id = 1, Name = "Position1", Salary = 10 },
                new PositionEntity() { Id = 2, Name = "Position2", Salary = 20 },
            };

            var departments = new List<DepartmentEntity>()
            {
                new DepartmentEntity() { Id = 1, Name = "Department1", Address = new Address() },
                new DepartmentEntity() { Id = 2, Name = "Department2", Address = new Address() },
            };

            var employees = new List<EmployeeEntity>()
            {
                new EmployeeEntity() { EmployeeId = 1, PositionId = 1, DepartmentId = 1, Name = "EmployeeName1", Surname = "EmployeeSurname1" },
                new EmployeeEntity() { EmployeeId = 2, PositionId = 1, DepartmentId = 1, Name = "EmployeeName2", Surname = "EmployeeSurname2" },
            };

            var positionsMock = Helpers.CreateDbSetMock(positions, "Id");
            var departmentsMock = Helpers.CreateDbSetMock(departments, "Id");
            var employeesMock = Helpers.CreateDbSetMock(employees, "EmployeeId");

            _appDbContextMock.Setup(x => x.Positions).Returns(positionsMock.Object);
            _appDbContextMock.Setup(x => x.Departments).Returns(departmentsMock.Object);
            _appDbContextMock.Setup(x => x.Employees).Returns(employeesMock.Object);

            _employeeService = new EFEmployeeService(_appDbContextMock.Object);
            var departmentService = new EFDepartmentService(_appDbContextMock.Object);
            var positionsService = new EFPositionService(_appDbContextMock.Object);

            _employeeController = new EmployeeController(_employeeService, departmentService, positionsService);
        }

        [Fact]
        public void Index_ShouldReturnViewWithEmployees()
        {
            var result = _employeeController.Index();
            Assert.IsType<ViewResult>(result);
            var view = result as ViewResult;
            var model = view.Model as PagingList<Employee>;
            Assert.Equal(2, model.Data.Count());
            Assert.Equal("Department1", model.Data.First().Department.Name);
            Assert.Equal("Position1", model.Data.First().Position.Name);
        }

        [Fact]
        public void CreateGet_ShouldReturnFormWithCorrectPositionList()
        {
            var result = _employeeController.Create();
            Assert.IsType<ViewResult>(result);
            var view = result as ViewResult;
            var model = view.Model as Employee;
            Assert.Equal(2, model.PositionList.Count());
            Assert.Equal("1", model.PositionList[0].Value);
            Assert.Equal("Position1", model.PositionList[0].Text);
            Assert.Equal("2", model.PositionList[1].Value);
            Assert.Equal("Position2", model.PositionList[1].Text);
        }

        [Fact]
        public void CreatePost_ModelIsInvalid_ShouldReturnFormWithSameModel()
        {
            var invalidEmployee = new Employee() { Name = "", Surname = "", Pesel = "1234", PositionId = 1, DepartmentId = 1 };

            _employeeController.ModelState.AddModelError("test", "model is invalid");
            var result = _employeeController.Create(invalidEmployee);
            Assert.IsType<ViewResult>(result);
            var view = result as ViewResult;
            var model = view.Model as Employee;
            Assert.Equal(model.Pesel, invalidEmployee.Pesel);
            Assert.Equal(model.Name, invalidEmployee.Name);
            Assert.Equal(model.Surname, invalidEmployee.Surname);
            Assert.Equal(model.PositionId, invalidEmployee.PositionId);
            Assert.Equal(model.DepartmentId, invalidEmployee.DepartmentId);
            Assert.Equal(model.EmploymentDate, invalidEmployee.EmploymentDate);
            Assert.Equal(model.SackingDate, invalidEmployee.SackingDate);
        }

        [Fact]
        public void CreatePost_ModelIsValid_ShouldAddNewEmloyeeAndRedirectToIndex()
        {
            var validEmployee = new Employee() { Name = "Name", Surname = "Surname", Pesel = "1234568901", PositionId = 1, DepartmentId = 1 };

            _employeeController.ModelState.Clear();
            var result = _employeeController.Create(validEmployee);
            Assert.IsType<RedirectToActionResult>(result);
            var redirectToIndexResult = result as RedirectToActionResult;
            Assert.Equal("Index", redirectToIndexResult.ActionName);
            Assert.Equal(3, _appDbContextMock.Object.Employees.Count());
            Assert.Equal("1234568901", _appDbContextMock.Object.Employees.Last().Pesel);
        }

        [Fact]
        public void UpdateGet_EmployeeIdDoesntExists_ShouldReturnNotFound()
        {
            var result = _employeeController.Update(-1);
            Assert.IsType<NotFoundResult>(result);
        }

        [Fact]
        public void UpdateGet_EmployeeIdExists_ShouldReturnFormWithPrefilledDataAndCorrectPositionList()
        {
            var result = _employeeController.Update(1);
            Assert.IsType<ViewResult>(result);
            var view = result as ViewResult;
            var model = view.Model as Employee;
            Assert.Equal("EmployeeName1", model.Name);
            Assert.Equal("EmployeeSurname1", model.Surname);
            Assert.Equal(1, model.PositionId);
            Assert.Equal(1, model.DepartmentId);
            Assert.Equal(2, model.PositionList.Count());
            Assert.Equal("1", model.PositionList[0].Value);
            Assert.Equal("Position1", model.PositionList[0].Text);
            Assert.Equal("2", model.PositionList[1].Value);
            Assert.Equal("Position2", model.PositionList[1].Text);
        }

        [Fact]
        public void UpdatePost_ModelIsInvalid_ShouldReturnFormWithSameModel()
        {
            var invalidEmployee = new Employee() { Id = 1, Name = "", Surname = "", Pesel = "1234", PositionId = 1, DepartmentId = 1 };

            _employeeController.ModelState.AddModelError("test", "model is invalid");
            var result = _employeeController.Update(invalidEmployee);
            Assert.IsType<ViewResult>(result);
            var view = result as ViewResult;
            var model = view.Model as Employee;
            Assert.Equal(model.Pesel, invalidEmployee.Pesel);
            Assert.Equal(model.Name, invalidEmployee.Name);
            Assert.Equal(model.Surname, invalidEmployee.Surname);
            Assert.Equal(model.PositionId, invalidEmployee.PositionId);
            Assert.Equal(model.DepartmentId, invalidEmployee.DepartmentId);
            Assert.Equal(model.EmploymentDate, invalidEmployee.EmploymentDate);
            Assert.Equal(model.SackingDate, invalidEmployee.SackingDate);
        }

        [Fact]
        public void UpdatePost_ModelIsValid_ShouldUpdateEmloyeeAndRedirectToIndex()
        {
            var validEmployee = new Employee() { Id = 1, Name = "UpdatedName", Surname = "UpdatedSurname", Pesel = "1234568901", PositionId = 1, DepartmentId = 1 };

            _employeeController.ModelState.Clear();
            var result = _employeeController.Update(validEmployee);
            Assert.IsType<RedirectToActionResult>(result);
            var redirectToIndexResult = result as RedirectToActionResult;
            Assert.Equal("Index", redirectToIndexResult.ActionName);
            Assert.Equal(2, _appDbContextMock.Object.Employees.Count());
            Assert.Equal("UpdatedName", _appDbContextMock.Object.Employees.First().Name);
            Assert.Equal("UpdatedSurname", _appDbContextMock.Object.Employees.First().Surname);
        }

        [Fact]
        public void DeleteGet_EmployeeIdDoesntExists_ShouldReturnNotFound()
        {
            var result = _employeeController.Delete(-1);
            Assert.IsType<NotFoundResult>(result);
        }

        [Fact]
        public void DeleteGet_EmployeeIdExists_ShouldReturnViewWithDeleteConfirmation()
        {
            var result = _employeeController.Delete(1);
            Assert.IsType<ViewResult>(result);
            var view = result as ViewResult;
            var model = view.Model as Employee;
            Assert.Equal("EmployeeName1", model.Name);
            Assert.Equal("EmployeeSurname1", model.Surname);
        }

        [Fact]
        public void DeletePost_ShouldDeleteEmloyeeAndRedirectToIndex()
        {
            var employeeToDelete = new Employee() { Id = 1 };

            var result = _employeeController.Delete(employeeToDelete);
            Assert.IsType<RedirectToActionResult>(result);
            var redirectToIndexResult = result as RedirectToActionResult;
            Assert.Equal("Index", redirectToIndexResult.ActionName);
            Assert.Equal(1, _appDbContextMock.Object.Employees.Count());
            Assert.Equal("EmployeeName2", _appDbContextMock.Object.Employees.First().Name);
            Assert.Equal("EmployeeSurname2", _appDbContextMock.Object.Employees.First().Surname);
        }

        [Fact]
        public void DetailsGet_EmployeeIdDoesntExists_ShouldReturnNotFound()
        {
            var result = _employeeController.Details(-1);
            Assert.IsType<NotFoundResult>(result);
        }

        [Fact]
        public void DetailsGet_EmployeeIdExists_ShouldShowEmployeeDetails()
        {
            var result = _employeeController.Details(1);
            Assert.IsType<ViewResult>(result);
            var view = result as ViewResult;
            var model = view.Model as Employee;
            Assert.Equal("EmployeeName1", model.Name);
            Assert.Equal("EmployeeSurname1", model.Surname);
            Assert.Equal("Position1", model.Position.Name);
            Assert.Equal("Department1", model.Department.Name);
        }
    }
}