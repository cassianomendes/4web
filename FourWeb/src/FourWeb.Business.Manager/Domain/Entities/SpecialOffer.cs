using FourWeb.Abstraction.Domain.Entities;
using System;

namespace FourWeb.Business.Manager.Domain.Entities
{
    public class SpecialOffer : EntityBase
    {
        public SpecialOffer()
        {

        }        
        public string Description { get; private set; }
        public decimal DiscountPercentage { get; private set; }
        public string Type { get; private set; }
        public string Category { get; private set; }
        public DateTime StartDate { get; private set; }
        public DateTime EndDate { get; private set; }
        public int MinQuantity { get; private set; }
        public int MaxQuantity { get; private set; }
    }
}
