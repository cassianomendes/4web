using FourWeb.Abstraction.Domain.Entities;
using System;
using System.Collections.Generic;

namespace FourWeb.Migrations.DatabaseModel
{
    public class SpecialOffer : EntityBase
    {
        public string Title { get; private set; }
        public string Description { get; private set; }
        public decimal DiscountPercentage { get; private set; }        
        public DateTime StartDate { get; private set; }
        public DateTime EndDate { get; private set; }   
        public ICollection<SpecialOfferProduct> SpecialOfferProducts { get; private set; }    
    }
}
