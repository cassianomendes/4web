using FourWeb.Abstraction.Data.Repositories;
using FourWeb.Abstraction.Domain.Entities;
using FourWeb.Business.Identity.Data.Context;
using FourWeb.Business.Identity.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FourWeb.Business.Identity.Data.Repositories
{
    public class UserRepository : RepositoryBase<User>, IUserRepository
    {
        public UserRepository(IdentityContext context)
            : base(context)
        {

        }
    }
}
