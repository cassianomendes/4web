using FourWeb.Abstraction.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FourWeb.Business.Shop.Domain.Entities
{
    public class Shipping : EntityBase
    {
        public Address Address { get; private set; }
        public double Weight { get; private set; }
        public decimal ShippingPrice { get; private set; }
        protected Shipping()
        {

        }

        public static Shipping Create(Address address)
        {
            return new Shipping()
            {
                Address = address
            };
        }
    }
}
