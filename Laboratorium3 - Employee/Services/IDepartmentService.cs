using Data.Entities;
using Laboratorium3___Employee.Models;

namespace Laboratorium3___Employee.Services
{
    public interface IDepartmentService
    {
        void Add(Department department);
        void Delete(int id);
        void Update(Department department);
        List<Department> FindAll();
        Department? FindById(int id);
        PagingList<Department> FindPage(int page, int size);
    }
}
