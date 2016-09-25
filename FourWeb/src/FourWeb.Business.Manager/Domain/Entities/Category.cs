using FourWeb.Abstraction.Domain.Entities;
using System.Collections.Generic;

namespace FourWeb.Business.Manager.Domain.Entities
{
    public class Category : EntityBase
    {
        protected Category()
        {            
        }

        public string Title { get; private set; }        

        public void UpdateTitle(string title)
        {
            this.Title = title;
        }

        public static Category Create(string title)
        {
            return new Category()
            {
                Title = title                
            };
        }
        public static Category Create(int id, string title)
        {
            return new Category()
            {
                Id = id,
                Title = title
            };
        }

    }
}
