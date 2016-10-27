using FourWeb.Abstraction.Domain.Entities;
using FourWeb.Abstraction.Domain.Interfaces.Repositories;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace FourWeb.Abstraction.Data.Repositories
{
    public abstract class RepositoryBase<T> : ContextRepositoryBase<T>, IRepositoryBase<T> where T : EntityBase
    {
        public RepositoryBase(DbContext context) 
            : base(context)
        {

        }
        public T Add(T entity)
        {
            var entry = Entity.Add(entity);
            return entry.Entity;
        }

        public void Delete(T entity)
        {
            Entity.Remove(entity);
        }

        public T GetById(int id)
        {
            return Entity.Where(e => e.Id == id).FirstOrDefault();
        }

        public void Save()
        {
            SaveChanges();
        }

        public void Update(T entity)
        {
            Entity.Update(entity);
        }
    }
}
