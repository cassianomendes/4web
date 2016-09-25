using FourWeb.Abstraction.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FourWeb.Migrations.DatabaseModel
{
    public class Shipping : EntityBase
    {
        public Address Address { get; private set; }
        public double Weight { get; private set; }
        public decimal ShippingPrice { get; private set; }
    }
}
