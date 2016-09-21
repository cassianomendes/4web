using FourWeb.Abstraction.Domain.Entities;

namespace FourWeb.Business.Shop.Domain.Entities
{
    public class Address : EntityBase
    {
        public Address(string country, string postalCode, string province, string city, string name, string address1, string address2 = null)
        {
            this.Country = country;
            this.PostalCode = postalCode;
            this.Province = province;
            this.City = city;
            this.Name = name;
            this.Address1 = address1;
            this.Address2 = address2;
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
