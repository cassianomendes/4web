using FourWeb.Abstraction.Domain.Entities;
using FourWeb.Abstraction.Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FourWeb.Abstraction.Domain.Services
{
    public class CommandService<T> where T : EntityBase
    {
        private readonly IRepositoryBase<T> _repository;
        public CommandService(IRepositoryBase<T> repository)
        {
            _repository = repository;
        }

        public virtual void Create(T entity)
        {
            _repository.Add(entity);
            _repository.Save();
        }

        public virtual void Update(T entity)
        {
            _repository.Update(entity);
            _repository.Save();
        }

        public virtual void Delete(T entity)
        {
            _repository.Delete(entity);
            _repository.Save();
        }

        public virtual T GetById(int id)
        {
            return _repository.GetById(id);
        }
    }
}
