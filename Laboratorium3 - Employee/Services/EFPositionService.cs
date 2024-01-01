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

        public void Add(Position position)
        {
            context.Positions.Add(PositionMapper.GetEntityFromModel(position));
            context.SaveChanges();
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

        public PagingList<Position> FindPage(int page, int size)
        {
            var pagingList = PagingList<Position>.Create(null, context.Positions.Count(), page, size);
            var data = context.Positions
                .OrderBy(position => position.Name)
                .Skip((pagingList.Number - 1) * pagingList.Size)
                .Take(pagingList.Size)
                .Select(PositionMapper.GetModelFromEntity)
                .ToList();
            pagingList.Data = data;
            return pagingList;
        }
    }
}
