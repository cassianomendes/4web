using System;
using System.Collections.Generic;

namespace FourWeb.Business.Report.ViewModels
{
    public class OrderDetailViewModel
    {
        public OrderDetailViewModel()
        {
            Items = new List<OrderDetailItemViewModel>();
        }

        public DateTime Date { get; set; }
        public decimal Total { get; set; }
        public int Status { get; set; }
        public decimal Discount { get; set; }
        public OrderDetailShippingAddressViewModel ShippingAddress { get; set; }
        public OrderDetailPaymentViewModel Payment { get; set; }
        public ICollection<OrderDetailItemViewModel> Items { get; set; }
    }
}
