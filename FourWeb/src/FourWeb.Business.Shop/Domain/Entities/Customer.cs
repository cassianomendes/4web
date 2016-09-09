using FourWeb.Abstraction.Domain.Entities;
using System.Collections.Generic;

namespace FourWeb.Business.Shop.Domain.Entities
{
    public class Customer : User
    {
        protected Customer()
        {
            this.ShippingAddress = new List<Address>();
        }

        public ICollection<Address> ShippingAddress { get; private set; }
    }
}
