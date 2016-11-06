using FourWeb.Business.Shop.Domain.ValueObjects;
using System;

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

        public static CreditCard Create(string name, string cardNumber, int month,
                                        int year, int securityCode, int cardType)
        {
            return new CreditCard()
            {
                CardType = (CreditCardType)Enum.Parse(typeof(CreditCardType), cardType.ToString()),
                CardNumber = cardNumber,
                Name = name,
                ExpirationMonth = month,
                ExpirationYear = year
            };
        }
    }
}