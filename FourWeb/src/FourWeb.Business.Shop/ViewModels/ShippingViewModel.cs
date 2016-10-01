namespace FourWeb.Business.Shop.ViewModels
{
    public class ShippingViewModel
    {
        public int TotalWeekdays { get; set; }
        public decimal ShippingPrice { get; set; }
        public ShippingAddressViewModel Address { get; set; }

    }
}
