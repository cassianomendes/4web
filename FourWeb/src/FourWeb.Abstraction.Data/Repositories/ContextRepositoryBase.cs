using FourWeb.Abstraction.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FourWeb.Abstraction.Data.Repositories
{
    public abstract class ContextRepositoryBase<T> where T : EntityBase
    {
        private readonly DbContext _context;
        protected DbSet<T> Entity { get; private set; }
        public ContextRepositoryBase(DbContext context)
        {
            if (context == null) throw new ArgumentNullException(nameof(context));

            _context = context;
            Entity = _context.Set<T>();
        }
        protected void SaveChanges()
        {
            _context.SaveChanges();
        }
    }
}
