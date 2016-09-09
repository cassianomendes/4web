using FourWeb.Abstraction.Domain.Entities;
using System.Collections.Generic;

namespace FourWeb.Business.Manager.Domain.Entities
{
    public class Category : EntityBase
    {
        protected Category()
        {
            this.SubCategories = new List<Category>();
        }

        public Category(string title) : this()
        {
            this.Title = title;
        }

        public string Title { get; private set; }
        public ICollection<Category> SubCategories { get; set; }

        public void UpdateTitle(string title)
        {
            this.Title = title;
        }
    }
}
