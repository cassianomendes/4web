using FourWeb.Abstraction.Domain.Entities;
using FourWeb.Abstraction.Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FourWeb.Abstraction.Domain.Services
{
    public abstract class QueryService<T> where T : EntityBase
    {
        private readonly IRepositoryQueryBase<T> _repository;
        public QueryService(IRepositoryQueryBase<T> repository)
        {
            _repository = repository;
        }

        public virtual T GetById(int id)
        {
            return _repository.GetById(id);
        }
    }
}
