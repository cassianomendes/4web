using FourWeb.Abstraction.Domain.Entities;

namespace FourWeb.Business.Report.Domain.Entities
{
    public class Product : EntityBase
    {
        protected Product()
        {
        }

        public string Title { get; private set; }
    }
}
