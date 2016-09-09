using FourWeb.Abstraction.Domain.Entities;
using System;

namespace FourWeb.Business.Shop.Domain.Entities
{
    public class Payment : EntityBase
    {
        public Payment()
        {

        }        
        public DateTime Paid { get; private set; }
        public decimal Total { get; private set; }
    }
}
