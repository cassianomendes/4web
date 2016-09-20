using FourWeb.Abstraction.Domain.Entities;
using FourWeb.Abstraction.Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace FourWeb.Abstraction.Data.Repositories
{
    public abstract class RepositoryBase<T> : ContextRepositoryBase<T>, IRepositoryBase<T> where T : EntityBase
    {
        public RepositoryBase(DbContext context) 
            : base(context)
        {

        }
        public void Add(T entity)
        {
            Entity.Add(entity);
        }

        public void Delete(T entity)
        {
            Entity.Remove(entity);
        }

        public void Update(T entity)
        {
            Entity.Update(entity);
        }
    }
}
