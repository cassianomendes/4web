using System;

namespace FourWeb.Business.Report.ViewModels
{
    public class OrderDetailPaymentViewModel
    {
        public DateTime Paid { get; private set; }
        public decimal Total { get; private set; }
    }
}
