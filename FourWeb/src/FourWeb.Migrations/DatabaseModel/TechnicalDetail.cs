using FourWeb.Abstraction.Domain.Entities;

namespace FourWeb.Migrations.DatabaseModel
{
    public class TechnicalDetail : EntityBase
    {
        public string Title { get; private set; }
        public string Description { get; private set; }       
    }
}
