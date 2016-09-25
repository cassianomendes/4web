using FourWeb.Abstraction.Domain.Entities;
using System.Collections.Generic;

namespace FourWeb.Migrations.DatabaseModel
{
    public class Product : EntityBase
    {
        public string Title { get; private set; }
        public string Description { get; private set; }
        public decimal Price { get; private set; }
        public int QuantityOnHand { get; private set; }
        public int CategoryId { get; private set; }
        public string Image { get; private set; }
        public Category Category { get; private set; }
        public ICollection<TechnicalDetail> TechnicalDetails { get; protected set; }
        public ICollection<Product> RelatedProducts { get; protected set; }
        public ICollection<SpecialOfferProduct> SpecialOfferProduct { get; protected set; }       
    }
}
