using Data.Entities;
using Laboratorium3___Employee.Models;

namespace Laboratorium3___Employee.Helpers
{
    public static class PositionMapper
    {
        public static PositionEntity GetEntityFromModel(Position position)
        {
            return new PositionEntity()
            {
                Id = position.Id,
                Name = position.Name,
                Salary = position.Salary
            };
        }

        public static Position GetModelFromEntity(PositionEntity entity)
        {
            return new Position()
            {
                Id = entity.Id,
                Name = entity.Name,
                Salary = entity.Salary
            };
        }
    }
}
