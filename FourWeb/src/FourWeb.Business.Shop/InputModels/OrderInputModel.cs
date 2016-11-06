using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FourWeb.Business.Shop.InputModels
{
    public class OrderInputModel
    {
        public int PaymentMethodId { get; set; }
        public int AddressId { get; set; }  
        public string CouponCode { get; set; }        
        public CreditCardInputModel CreditCard { get; set; }
    }
}
