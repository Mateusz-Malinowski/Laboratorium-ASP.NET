using Data.Entities;
using Data;
using Laboratorium3___Employee.Models;
using Laboratorium3___Employee.Helpers;

namespace Laboratorium3___Employee.Services
{
    public class EFPositionService : IPositionService
    {
        private readonly AppDbContext context;

        public EFPositionService(AppDbContext context)
        {
            this.context = context;
        }

        public int Add(Position position)
        {
            var entry = context.Positions.Add(PositionMapper.GetEntityFromModel(position));
            context.SaveChanges();
            int id = entry.Entity.Id;
            return id;
        }

        public void Delete(int id)
        {
            PositionEntity? entity = context.Positions.Find(id);
            if (entity is null) throw new Exception();

            context.Positions.Remove(entity);
            context.SaveChanges();
        }

        public List<Position> FindAll()
        {
            return context.Positions.Select(entity => PositionMapper.GetModelFromEntity(entity)).ToList();
        }

        public Position? FindById(int id)
        {
            PositionEntity? entity = context.Positions.Find(id);

            return entity is null ? null : PositionMapper.GetModelFromEntity(entity);
        }

        public void Update(Position employee)
        {
            context.Positions.Update(PositionMapper.GetEntityFromModel(employee));
            context.SaveChanges();
        }
    }
}
