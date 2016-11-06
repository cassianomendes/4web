using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FourWeb.Business.Shop.InputModels
{
    public class CreditCardInputModel
    {
        public int CardType { get; set; }
        public string Name { get; set; }
        public string CardNumber { get; set; }
        public int ExpirationMonth { get; set; }
        public int ExpirationYear { get; set; }
        public int SecurityCode { get; set; }
    }
}
