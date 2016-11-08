using FourWeb.Abstraction.Domain.Entities;
using System;

namespace FourWeb.Business.Report.Domain.Entities
{
    public class Payment : EntityBase
    {
        protected Payment()
        {

        }
        public DateTime Paid { get; private set; }
        public decimal Total { get; private set; }
    }
}
