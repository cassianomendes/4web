using System.Collections.Generic;
using System.Linq;

namespace FourWeb.Business.Shop.ViewModels
{
    public class ShoppingCartViewModel
    {
        public ShoppingCartViewModel()
        {
            this.Items = new List<ShoppingCartItemViewModel>();
        }

        public IEnumerable<ShoppingCartItemViewModel> Items { get; set; }

        public decimal Total
        {
            get
            {
                return this.Items.Sum(x => x.Subtotal);
            }
        }
    }
}
