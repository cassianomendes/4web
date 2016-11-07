using FourWeb.Abstraction.Domain.Entities;
using System;

namespace FourWeb.Business.Report.Domain.Entities
{
    public class Order : EntityBase
    {
        protected Order()
        {

        }

        public DateTime Date { get; private set; }
        public int CustomerId { get; private set; }
    }
}
