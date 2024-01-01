using Data.Entities;
using Data;
using Laboratorium3___Employee.Models;
using Laboratorium3___Employee.Helpers;

namespace Laboratorium3___Employee.Services
{
    public class EFEmployeeService : IEmployeeService
    {
        private readonly AppDbContext context;

        public EFEmployeeService(AppDbContext context)
        {
            this.context = context;
        }

        public void Add(Employee employee)
        {
            context.Employees.Add(EmployeeMapper.GetEntityFromModel(employee));
            context.SaveChanges();
        }

        public void Delete(int id)
        {
            EmployeeEntity? entity = context.Employees.Find(id);
            if (entity is null) throw new Exception();

            context.Employees.Remove(entity);
            context.SaveChanges();
        }

        public List<Employee> FindAll()
        {
            return context.Employees.Select(entity => EmployeeMapper.GetModelFromEntity(entity)).ToList();
        }

        public Employee? FindById(int id)
        {
            EmployeeEntity? entity = context.Employees.Find(id);

            return entity is null ? null : EmployeeMapper.GetModelFromEntity(entity);
        }

        public void Update(Employee employee)
        {
            context.Employees.Update(EmployeeMapper.GetEntityFromModel(employee));
            context.SaveChanges();
        }

        public PagingList<Employee> FindPage(int page, int size)
        {
            var pagingList = PagingList<Employee>.Create(null, context.Employees.Count(), page, size);
            var data = context.Employees
                .OrderBy(employee => employee.Name)
                .Skip((pagingList.Number - 1) * pagingList.Size)
                .Take(pagingList.Size)
                .Select(EmployeeMapper.GetModelFromEntity)
                .ToList();
            pagingList.Data = data;
            return pagingList;
        }
    }
}
