using FourWeb.Abstraction.Domain.Entities;
using FourWeb.Abstraction.Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FourWeb.Business.Identity.Domain.Repositories
{
    public interface IUserRepository : IRepositoryBase<User>
    {
        User GetByUsername(string userName);
    }
}
