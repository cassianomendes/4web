using FourWeb.Abstraction.Domain.Entities;
using System;

namespace FourWeb.Migrations.DatabaseModel
{
    public class Payment : EntityBase
    {
        public DateTime Paid { get; private set; }
        public decimal Total { get; private set; }
    }
}
