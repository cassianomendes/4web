using FourWeb.Abstraction.Domain.Entities;
using System;

namespace FourWeb.Business.Shop.Domain.Entities
{
    public class ProductReview : EntityBase
    {
        public ProductReview()
        {

        }

        public int Id { get; private set; }
        public int ProductId { get; private set; }
        public Product Product { get; private set; }
        public string ReviewerName { get; private set; }
        public DateTime ReviewDate { get; private set; }
        public string EmailAddress { get; private set; }
        public decimal Rating { get; private set; }
        public string Comments { get; private set; }
        public DateTime ModifiedDate { get; private set; }
    }
}
