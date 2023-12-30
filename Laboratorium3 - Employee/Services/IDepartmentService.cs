using Data.Entities;
using Laboratorium3___Employee.Models;

namespace Laboratorium3___Employee.Services
{
    public interface IDepartmentService
    {
        int Add(Department department);
        void Delete(int id);
        void Update(Department department);
        List<Department> FindAll();
        Department? FindById(int id);
    }
}
