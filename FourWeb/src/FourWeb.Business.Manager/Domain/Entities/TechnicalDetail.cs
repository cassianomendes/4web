using FourWeb.Abstraction.Domain.Entities;

namespace FourWeb.Business.Manager.Domain.Entities
{
    public class TechnicalDetail : EntityBase
    {
        public TechnicalDetail(string title, string description)
        {
            this.Title = title;
            this.Description = description;
        }

        public int Id { get; private set; }
        public string Title { get; private set; }
        public string Description { get; private set; }

        public void UpdateInfo(string title, string description)
        {
            this.Title = title;
            this.Description = description;
        }
    }
}
