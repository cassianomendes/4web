using FourWeb.Business.Shop.Domain.ValueObjects;

namespace FourWeb.Business.Shop.Domain.Entities
{
    public class CreditCard : Payment
    {
        protected CreditCard()
        {
        }

        public CreditCardType CardType { get; private set; }
        public string Name { get; private set; }
        public string CardNumber { get; private set; }
        public int ExpirationMonth { get; private set; }
        public int ExpirationYear { get; private set; }
        public int SecurityCode { get; private set; }
    }
}
