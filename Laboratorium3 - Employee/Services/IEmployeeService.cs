using Data.Entities;
using Laboratorium3___Employee.Models;

namespace Laboratorium3___Employee.Services
{
    public interface IEmployeeService
    {
        int Add(Employee employee);
        void Delete(int id);
        void Update(Employee employee);
        List<Employee> FindAll();
        Employee? FindById(int id);
        List<DepartmentEntity> FindAllDepartments();
    }
}
