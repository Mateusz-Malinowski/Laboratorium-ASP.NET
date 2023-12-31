﻿using Data.Entities;
using Laboratorium3___Employee.Models;

namespace Laboratorium3___Employee.Services
{
    public interface IPositionService
    {
        void Add(Position position);
        void Delete(int id);
        void Update(Position position);
        List<Position> FindAll();
        Position? FindById(int id);
        PagingList<Position> FindPage(int page, int size);
    }
}
