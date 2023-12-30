using Data.Entities;
using Laboratorium3___Employee.Models;

namespace Laboratorium3___Employee.Helpers
{
    public static class DepartmentMapper
    {
        public static DepartmentEntity GetEntityFromModel(Department department)
        {
            return new DepartmentEntity()
            {
                Id = department.Id,
                Name = department.Name,
                Description = department.Description,
                Address = department.Address
            };
        }

        public static Department GetModelFromEntity(DepartmentEntity entity)
        {
            return new Department()
            {
                Id = entity.Id,
                Name = entity.Name,
                Description = entity.Description,
                Address = entity.Address
            };
        }
    }
}
