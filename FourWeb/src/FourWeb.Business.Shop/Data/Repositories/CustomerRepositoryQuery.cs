using FourWeb.Abstraction.Data.Repositories;
using FourWeb.Business.Shop.Data.Contexts;
using FourWeb.Business.Shop.Domain.Entities;
using FourWeb.Business.Shop.Domain.Repositories;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace FourWeb.Business.Shop.Data.Repositories
{
    public class CustomerRepositoryQuery : RepositoryQueryBase<Customer>, ICustomerRepositoryQuery
    {
        public CustomerRepositoryQuery(ShopContext context)
            : base(context)
        {
        }

        public Customer GetByEmail(string email)
        {
            return Entity.AsNoTracking().FirstOrDefault(x => x.Email == email);
        }
    }
}
