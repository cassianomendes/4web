﻿using FourWeb.Abstraction.Domain.Entities;
using System;
using System.Collections.Generic;

namespace FourWeb.Business.Manager.Domain.Entities
{
    public class SpecialOffer : EntityBase
    {
        public SpecialOffer()
        {
            SpecialOfferProducts = new List<SpecialOfferProduct>();
        }
        public string Title { get; private set; }
        public string Description { get; private set; }
        public decimal DiscountPercentage { get; private set; }        
        public DateTime StartDate { get; private set; }
        public DateTime EndDate { get; private set; }   
        public ICollection<SpecialOfferProduct> SpecialOfferProducts { get; private set; }    
    }
}
