using FourWeb.Abstraction.Domain.Entities;
using System;

namespace FourWeb.DatabaseModel
{
    public class SpecialOfferProduct : EntityBase
    {
        public int SpecialOfferId { get; private set; }
        public SpecialOffer SpecialOffer { get; private set; }
        public int ProductId { get; private set; }
        public Product Product { get; private set; }
        public DateTime ModifiedDate { get; private set; }
    }
}
