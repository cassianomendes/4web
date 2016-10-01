namespace FourWeb.Business.Shop.ViewModels
{
    public class ShoppingCartItemViewModel
    {
        public string ProductName { get; set; }
        public decimal ProductPrice { get; set; }
        public int Quantity { get; set; }
        public decimal Subtotal
        {
            get
            {
                return this.ProductPrice * this.Quantity;
            }
        }
    }
}
