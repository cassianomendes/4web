namespace FourWeb.Business.Shop.Domain.Entities
{
    public class BankSlip : Payment
    {
        protected BankSlip()
            : base()
        {

        }

        public static BankSlip Create()
        {
            return new BankSlip();
        }
    }
}