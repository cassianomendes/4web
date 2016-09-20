using FourWeb.Abstraction.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FourWeb.Abstraction.Domain.Interfaces.Repositories
{
    public interface IRepositoryQueryBase<T> where T : EntityBase
    {
        T GetById(int id);
    }
}
