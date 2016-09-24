using FourWeb.Abstraction.Domain.Entities;
using System.Collections.Generic;

namespace FourWeb.DatabaseModel
{
    public class Category : EntityBase
    {
        public string Title { get; private set; }
        public ICollection<Category> SubCategories { get; set; }

    }
}
