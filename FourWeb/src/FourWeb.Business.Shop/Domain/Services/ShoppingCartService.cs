using FourWeb.Business.Shop.Domain.Entities;
using FourWeb.Business.Shop.Domain.Repositories;
using System;

namespace FourWeb.Business.Shop.Domain.Services
{
    public class ShoppingCartService
    {
        private readonly IShoppingCartRepository _shoppingCartRepository;
        private readonly ICustomerRepositoryQuery _customerRepositoryQuery;

        public ShoppingCartService(
            IShoppingCartRepository shoppingCartRepository,
            ICustomerRepositoryQuery customerRepositoryQuery)
        {
            _shoppingCartRepository = shoppingCartRepository;
            _customerRepositoryQuery = customerRepositoryQuery;
        }

        public ShoppingCart GetByCustomer(string email)
        {
            if (string.IsNullOrEmpty(email))
                throw new ArgumentNullException(nameof(email));

            var customer = _customerRepositoryQuery.GetByEmail(email);

            return _shoppingCartRepository.GetByCustomer(customer.Id);
        }

        public void AddItem(string email, ShoppingCartItem item)
        {
            if (string.IsNullOrEmpty(email))
                throw new ArgumentNullException(nameof(email));

            if (item == null)
                throw new ArgumentNullException(nameof(item));

            var shoppingCart = this.GetByCustomer(email);

            // Se ainda não existe carrinho de compras
            // para o usuário, então cria-o sem itens
            if (shoppingCart == null)
            {
                var customer = _customerRepositoryQuery.GetByEmail(email);
                shoppingCart = _shoppingCartRepository.Add(ShoppingCart.Create(customer.Id));
            }

            shoppingCart.AddItem(item);
            _shoppingCartRepository.Update(shoppingCart);
            _shoppingCartRepository.Save();
        }

        public void UpdateItemQuantity(string email, ShoppingCartItem item)
        {
            ShoppingCart shoppingCart = this.GetByCustomer(email);
            shoppingCart.UpdateItemQuantity(item);
            _shoppingCartRepository.Update(shoppingCart);
            _shoppingCartRepository.Save();
        }

        public void DeleteItem(string email, int productId)
        {
            var shoppingCart = this.GetByCustomer(email);
            shoppingCart.DeleteItemByProduct(productId);
            _shoppingCartRepository.Update(shoppingCart);
            _shoppingCartRepository.Save();
        }
    }
}
