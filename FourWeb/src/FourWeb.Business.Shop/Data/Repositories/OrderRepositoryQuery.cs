using FourWeb.Abstraction.Data.Repositories;
using FourWeb.Business.Shop.Data.Contexts;
using FourWeb.Business.Shop.Domain.Entities;
using FourWeb.Business.Shop.Domain.Repositories;

namespace FourWeb.Business.Shop.Data.Repositories
{
    public class OrderRepositoryQuery : RepositoryQueryBase<Order>, IOrderRepositoryQuery
    {
        public OrderRepositoryQuery(ShopContext context)
            : base(context)
        {
        }
    }
}
