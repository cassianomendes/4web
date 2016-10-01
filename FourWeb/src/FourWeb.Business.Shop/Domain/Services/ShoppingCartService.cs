using FourWeb.Business.Shop.Domain.Entities;
using FourWeb.Business.Shop.Domain.Repositories;
using FourWeb.Business.Shop.ViewModels;
using System.Linq;

namespace FourWeb.Business.Shop.Domain.Services
{
    public class ShoppingCartService
    {
        private readonly IShoppingCartRepository _shoppingCartRepository;

        public ShoppingCartService(IShoppingCartRepository shoppingCartRepository)
        {
            _shoppingCartRepository = shoppingCartRepository;
        }

        public ShoppingCartViewModel Get(int userId)
        {
            return
                new ShoppingCartViewModel
                {
                    Items =
                        from shoppingCart in _shoppingCartRepository.AsQueryable()
                        where shoppingCart.Customer.Id == userId
                        from item in shoppingCart.ShoppingCartItems
                        select
                            new ShoppingCartItemViewModel
                            {
                                ProductName = item.Product.Title,
                                ProductPrice = item.Product.Price,
                                Quantity = item.Quantity
                            }
                };
        }

        public void NewItem(int userId, ShoppingCartItem item)
        {
            var shoppingCart = _shoppingCartRepository.AsQueryable().Single(x => x.Customer.Id == userId);
            
        }
    }
}
