using FourWeb.Abstraction.Domain.Entities;

namespace FourWeb.Business.Shop.Domain.Entities
{
    public class Product : EntityBase
    {
        protected Product()
        {
        }        
        public int QuantityOnHand { get; private set; }        

        public void UpdateQuantityOnHand(int amount)
        {
            this.QuantityOnHand = amount;
        }        
    }
}
