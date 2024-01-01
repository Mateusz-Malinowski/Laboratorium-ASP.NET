using Data.Entities;
using Laboratorium3___Employee.Models;

namespace Laboratorium3___Employee.Services
{
    public class MemoryEmployeeService : IEmployeeService
    {
        private Dictionary<int, Employee> _items = new Dictionary<int, Employee>();

        public void Add(Employee item)
        {
            int id = _items.Keys.Count != 0 ? _items.Keys.Max() : 0;
            item.Id = id + 1;
            _items.Add(item.Id, item);
        }

        public void Delete(int id)
        {
            _items.Remove(id);
        }

        public List<Employee> FindAll()
        {
            return _items.Values.ToList();
        }

        public Employee? FindById(int id)
        {
            return _items[id];
        }

        public void Update(Employee item)
        {
            _items[item.Id] = item;
        }

        public List<DepartmentEntity> FindAllDepartments()
        {
            throw new NotImplementedException();
        }

        public PagingList<Employee> FindPage(int page, int size)
        {
            throw new NotImplementedException();
        }
    }
}
