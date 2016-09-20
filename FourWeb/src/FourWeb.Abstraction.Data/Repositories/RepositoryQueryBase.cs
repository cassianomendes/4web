using FourWeb.Abstraction.Domain.Entities;
using FourWeb.Abstraction.Domain.Interfaces.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FourWeb.Abstraction.Data.Repositories
{
    public abstract class RepositoryQueryBase<T> : ContextRepositoryBase<T>, IRepositoryQueryBase<T> where T : EntityBase
    {        
        public RepositoryQueryBase(DbContext context) 
            : base(context)
        {            
        }

        public T GetById(int id)
        {
            return Entity.FirstOrDefault(e => e.Id == id);
        }

        public T GetByIdAsNoTracking(int id)
        {
            return Entity.AsNoTracking().FirstOrDefault(e => e.Id == id);
        }
    }
}
