using AutoMapper;
using FourWeb.Business.Shop.Domain.Entities;
using FourWeb.Business.Shop.InputModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FourWeb.Business.Shop.Mappings
{
    public class CreditCardTypeConverter : ITypeConverter<CreditCardInputModel, CreditCard>
    {
        public CreditCard Convert(CreditCardInputModel source, CreditCard destination, ResolutionContext context)
        {
            if (source == null) return null;

            return CreditCard.Create(source.Name, source.CardNumber, source.ExpirationMonth,
                source.ExpirationYear, source.SecurityCode, source.CardType);
        }
    }
}
