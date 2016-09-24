using FourWeb.Abstraction.Domain.Entities;

namespace FourWeb.DatabaseModel
{
    public class Address : EntityBase
    {    
        public string Country { get; private set; }
        public string PostalCode { get; private set; }
        public string Province { get; private set; }
        public string City { get; private set; }
        public string Address1 { get; private set; }
        public string Address2 { get; private set; }
        public string Name { get; private set; }
    }
}
