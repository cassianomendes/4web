using System;

namespace FourWeb.Business.Report.ViewModels
{
    public class OrderViewModel
    {
        public DateTime Date { get; set; }
        public decimal Total { get; set; }
        public int Status { get; set; }
    }
}
