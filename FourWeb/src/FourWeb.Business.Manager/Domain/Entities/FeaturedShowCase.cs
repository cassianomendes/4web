using FourWeb.Abstraction.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FourWeb.Business.Manager.Domain.Entities
{
    public class FeaturedShowCase : EntityBase
    {
        public int ProductId { get; private set; }
        public Product Product { get; private set; }

        protected FeaturedShowCase()
        {

        }

        public static FeaturedShowCase Create(Product product)
        {
            return new FeaturedShowCase()
            {
                ProductId = product.Id,
                Product = product
            };
        }
    }
}
