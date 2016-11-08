using FourWeb.Abstraction.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FourWeb.Business.Report.Domain.Entities
{
    public class Shipping : EntityBase
    {
        protected Shipping()
        {

        }

        public Address Address { get; private set; }
        public decimal ShippingPrice { get; private set; }
    }
}
