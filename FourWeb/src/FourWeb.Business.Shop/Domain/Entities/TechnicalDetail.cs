using FourWeb.Abstraction.Domain.Entities;

namespace FourWeb.Business.Shop.Domain.Entities
{
    public class TechnicalDetail : EntityBase
    {
        protected TechnicalDetail()
        {

        }

        public string Title { get; private set; }
        public string Description { get; private set; }
    }
}
