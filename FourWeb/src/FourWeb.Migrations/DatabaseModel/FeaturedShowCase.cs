using FourWeb.Abstraction.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FourWeb.Migrations.DatabaseModel
{
    public class FeaturedShowCase : EntityBase
    {        
        public ICollection<Product> Products { get; private set; }
    }
}
