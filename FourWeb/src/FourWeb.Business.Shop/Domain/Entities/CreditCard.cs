using FourWeb.Abstraction.Domain.Entities;

namespace FourWeb.Business.Shop.Domain.Entities
{
    public class CreditCard : EntityBase
    {
        public int Id { get; private set; }
        public string CardType { get; private set; }
        public string Name { get; set; }
        public string CardNumber { get; private set; }
        public int ExpirationMonth { get; private set; }
        public int ExpirationYear { get; private set; }
        public int SecurityCode { get; set; }
    }
}
