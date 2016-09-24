using FourWeb.Abstraction.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FourWeb.DatabaseModel
{
    public class Customer : User
    {
        public string Name { get; private set; }
        public string DocumentNumber { get; private set; }
        public string CreditCartNumber { get; private set; }
        public ICollection<Address> ShippingAddress { get; private set; }
    }
}
