using FourWeb.Abstraction.Domain.Interfaces.Repositories;
using FourWeb.Business.Shop.Domain.Entities;
using System.Linq;

namespace FourWeb.Business.Shop.Domain.Repositories
{
    public interface IShoppingCartRepository : IRepositoryQueryBase<ShoppingCart>
    {
        IQueryable<ShoppingCart> AsQueryable();
    }
}
