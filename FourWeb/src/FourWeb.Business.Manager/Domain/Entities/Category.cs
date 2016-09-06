using FourWeb.Abstraction.Domain.Entities;

namespace FourWeb.Business.Manager.Domain.Entities
{
    public class Category : EntityBase
    {
        protected Category() { }

        public Category(string title)
        {
            this.Title = title;
        }

        public int Id { get; private set; }
        public string Title { get; private set; }

        public void UpdateTitle(string title)
        {
            this.Title = title;
        }
    }
}
