namespace FourWeb.Business.Shop.Domain.Entities
{
    public class Product
    {
        public Product() { }

        public int Id { get; private set; }
        public int QuantityOnHand { get; private set; }

        public void UpdateQuantityOnHand(int amount)
        {
            this.QuantityOnHand = amount;
        }
    }
}
