using FourWeb.Business.Shop.Domain.ValueObjects;

namespace FourWeb.Migrations.DatabaseModel
{
    public class CreditCard : Payment
    {
        public CreditCardType CardType { get; private set; }
        public string Name { get; private set; }
        public string CardNumber { get; private set; }
        public int ExpirationMonth { get; private set; }
        public int ExpirationYear { get; private set; }
        public int SecurityCode { get; private set; }
    }
}
