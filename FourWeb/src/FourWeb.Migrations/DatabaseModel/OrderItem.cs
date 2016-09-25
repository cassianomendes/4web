using FourWeb.Abstraction.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FourWeb.Migrations.DatabaseModel
{
    public class OrderItem : EntityBase
    {        
        public int Quantity { get; private set; }
        public decimal UnitCost { get; private set; }

        public int ProductId { get; private set; }
        public Product Product { get; private set; }

        public int OrderId { get; private set; }
        public Order Order { get; private set; }

    }
}
