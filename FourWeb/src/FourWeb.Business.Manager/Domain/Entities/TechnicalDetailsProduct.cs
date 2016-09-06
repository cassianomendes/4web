using FourWeb.Abstraction.Domain.Entities;

namespace FourWeb.Business.Manager.Domain.Entities
{
    public class TechnicalDetailsProduct : EntityBase
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Weight { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public int Depth { get; set; }
    }
}
