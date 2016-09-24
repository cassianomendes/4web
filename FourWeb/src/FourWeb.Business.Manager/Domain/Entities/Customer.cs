using FourWeb.Abstraction.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FourWeb.Business.Manager.Domain.Entities
{
    public class Customer : User
    {
        protected Customer()
        {

        }
        public string Name { get; private set; }
        public string DocumentNumber { get; private set; }
        public string CreditCartNumber { get; private set; }

        public static Customer Create(string name, string creditCartNumber = "")
        {
            return new Customer()
            {
                Name = name,
                CreditCartNumber = creditCartNumber
            };
        }
    }
}
