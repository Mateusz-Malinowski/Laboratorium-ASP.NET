using Data.Entities;
using Data;
using Laboratorium3___Employee.Models;
using Laboratorium3___Employee.Helpers;

namespace Laboratorium3___Employee.Services
{
    public class EFDepartmentService : IDepartmentService
    {
        private readonly AppDbContext context;

        public EFDepartmentService(AppDbContext context)
        {
            this.context = context;
        }

        public int Add(Department department)
        {
            var entry = context.Departments.Add(DepartmentMapper.GetEntityFromModel(department));
            context.SaveChanges();
            int id = entry.Entity.Id;
            return id;
        }

        public void Delete(int id)
        {
            DepartmentEntity? entity = context.Departments.Find(id);
            if (entity is null) throw new Exception();

            context.Departments.Remove(entity);
            context.SaveChanges();
        }

        public List<Department> FindAll()
        {
            return context.Departments.Select(entity => DepartmentMapper.GetModelFromEntity(entity)).ToList();
        }

        public Department? FindById(int id)
        {
            DepartmentEntity? entity = context.Departments.Find(id);

            return entity is null ? null : DepartmentMapper.GetModelFromEntity(entity);
        }

        public void Update(Department employee)
        {
            context.Departments.Update(DepartmentMapper.GetEntityFromModel(employee));
            context.SaveChanges();
        }
    }
}
