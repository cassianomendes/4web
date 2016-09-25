using FourWeb.Abstraction.Data.Repositories;
using FourWeb.Business.Manager.Data.Contexts;
using FourWeb.Business.Manager.Domain.Entities;
using FourWeb.Business.Manager.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FourWeb.Business.Manager.Data.Repositories
{
    public class CategoryRepository : RepositoryBase<Category>, ICategoryRepository
    {        
        public CategoryRepository(ManagerContext context)
            : base(context)
        {

        }
    }
}
