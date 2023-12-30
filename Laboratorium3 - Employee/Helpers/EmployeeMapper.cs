using Data.Entities;
using Laboratorium3___Employee.Models;

namespace Laboratorium3___Employee.Helpers
{
    public static class EmployeeMapper
    {
        public static EmployeeEntity GetEntityFromModel(Employee employee)
        {
            return new EmployeeEntity()
            {
                EmployeeId = employee.Id,
                Pesel = employee.Pesel,
                Name = employee.Name,
                Surname = employee.Surname,
                EmploymentDate = employee.EmploymentDate,
                SackingDate = employee.SackingDate,
                Position = (int)employee.Position,
                DepartmentId = employee.DepartmentId
            };
        }

        public static Employee GetModelFromEntity(EmployeeEntity entity)
        {
            return new Employee()
            {
                Id = entity.EmployeeId,
                Pesel = entity.Pesel,
                Name = entity.Name,
                Surname = entity.Surname,
                EmploymentDate = entity.EmploymentDate,
                SackingDate = entity.SackingDate,
                Position = (Positions)entity.Position,
                DepartmentId = entity.DepartmentId
            };
        }
    }
}
