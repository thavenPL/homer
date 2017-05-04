﻿using System.Linq;

namespace homer.Repositories
{
    internal interface IRepository<T>
    {
        IQueryable<T> Get();
        T GetByID(int id);
        void Insert(T entity);
        void Delete(T entity);
        void Update(T entity);
        void Save();
    }
}