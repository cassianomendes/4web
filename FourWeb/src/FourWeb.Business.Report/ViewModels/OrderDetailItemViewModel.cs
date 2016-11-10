namespace FourWeb.Business.Report.ViewModels
{
    public class OrderDetailItemViewModel
    {
        public int Quantity { get; private set; }
        public decimal UnitCost { get; private set; }
        public string ProductTitle { get; set; }
    }
}
