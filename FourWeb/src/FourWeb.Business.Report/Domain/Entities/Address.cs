using FourWeb.Abstraction.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FourWeb.Business.Report.Domain.Entities
{
    public class Address : EntityBase
    {
        protected Address()
        {

        }

        public string Country { get; private set; }
        public string PostalCode { get; private set; }
        public string Province { get; private set; }
        public string City { get; private set; }
        public string Address1 { get; private set; }
        public string Address2 { get; private set; }
        public string Name { get; private set; }
    }
}
