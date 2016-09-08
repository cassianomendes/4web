using FourWeb.Abstraction.Domain.Entities;
using System;

namespace FourWeb.Business.Manager.Domain.Entities
{
    public class SpecialOfferProduct : EntityBase
    {
        public SpecialOfferProduct()
        {

        }

        public int SpecialOfferId { get; private set; }
        public SpecialOffer SpecialOffer { get; private set; }
        public int ProductId { get; private set; }
        public Product Product { get; private set; }
        public DateTime ModifiedDate { get; private set; }
    }
}
