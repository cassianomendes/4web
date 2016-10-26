using FourWeb.Abstraction.Domain.Entities;
using System.Collections.Generic;
using System.Linq;

namespace FourWeb.Business.Shop.Domain.Entities
{
    public class ShoppingCart : EntityBase
    {
        protected ShoppingCart()
        {
            this.ShoppingCartItems = new List<ShoppingCartItem>();
        }

        public ICollection<ShoppingCartItem> ShoppingCartItems { get; protected set; }
        public int Quantity
        {
            get
            {
                return ShoppingCartItems.Count;
            }
        }
        public Customer Customer { get; private set; }
        public int CustomerId { get; private set; }

        public static ShoppingCart Create(int customerId)
        {
            return new ShoppingCart()
            {
                CustomerId = customerId
            };
        }

        public static ShoppingCart Create(int customerId, IList<ShoppingCartItem> items)
        {
            return new ShoppingCart()
            {
                CustomerId = customerId,
                ShoppingCartItems = items
            };
        }

        public void AddItem(ShoppingCartItem item)
        {
            // Mantém integridade do carrinho, mantendo produtos únicos
            // no carrinho (ainda assim podem ter diferentes quantidade)
            if (!this.ShoppingCartItems.Any(x => x.ProductId == item.ProductId))
                this.ShoppingCartItems.Add(item);
        }

        public void UpdateItemQuantity(ShoppingCartItem item)
        {
            var existingItem = this.ShoppingCartItems.SingleOrDefault(x => x.ProductId == item.ProductId);
            existingItem.UpdateQuantity(item.Quantity);
        }

        public void DeleteItemByProduct(int productId)
        {
            var item = this.ShoppingCartItems.SingleOrDefault(x => x.ProductId == productId);
            if (item != null)
                this.ShoppingCartItems.Remove(item);
        }

        public Product GetBiggerProduct()
        {
            if (this.ShoppingCartItems.Count == 0)
                return null;

            var bigger = this.ShoppingCartItems.First();

            foreach (var item in this.ShoppingCartItems)
            {
                var diagonalCurrentItem = item.Product.GetDiagonal();
                var diagonalBiggerItem = bigger.Product.GetDiagonal();
                if (diagonalCurrentItem > diagonalBiggerItem)
                {
                    bigger = item;
                }
            }

            return bigger.Product;
        }
    }
}
