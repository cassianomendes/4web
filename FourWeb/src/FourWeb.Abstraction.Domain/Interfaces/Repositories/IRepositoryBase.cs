using FourWeb.Abstraction.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FourWeb.Abstraction.Domain.Interfaces.Repositories
{
    public interface IRepositoryBase<T> where T : EntityBase
    {
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
        T GetById(int id);
        void Save();
    }
}
