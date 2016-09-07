using FourWeb.Abstraction.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FourWeb.Business.Shop.Domain.Entities
{
    public class Payment : EntityBase
    {
        public Payment()
        {

        }

        public int Id { get; private set; }
        public DateTime Paid { get; private set; }
        public decimal Total { get; private set; }
    }
}
