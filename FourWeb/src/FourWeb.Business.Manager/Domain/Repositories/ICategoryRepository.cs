using FourWeb.Abstraction.Domain.Interfaces.Repositories;
using FourWeb.Business.Manager.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FourWeb.Business.Manager.Domain.Repositories
{
    public interface ICategoryRepository : IRepositoryBase<Category>
    {
    }
}
