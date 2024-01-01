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

        public void Add(Department department)
        {
            context.Departments.Add(DepartmentMapper.GetEntityFromModel(department));
            context.SaveChanges();
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

        public PagingList<Department> FindPage(int page, int size)
        {
            var pagingList = PagingList<Department>.Create(null, context.Departments.Count(), page, size);
            var data = context.Departments
                .OrderBy(department => department.Name)
                .Skip((pagingList.Number - 1) * pagingList.Size)
                .Take(pagingList.Size)
                .Select(DepartmentMapper.GetModelFromEntity)
                .ToList();
            pagingList.Data = data;
            return pagingList;
        }
    }
}
