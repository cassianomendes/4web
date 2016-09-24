using FourWeb.Abstraction.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FourWeb.Business.Manager.Domain.Entities
{
    public class FeaturedShowCase : EntityBase
    {        
        public ICollection<Product> Products { get; private set; }

        protected FeaturedShowCase()
        {

        }

        public static FeaturedShowCase Create(IList<Product> products)
        {
            return new FeaturedShowCase()
            {
                Products = products
            };
        }
    }
}
