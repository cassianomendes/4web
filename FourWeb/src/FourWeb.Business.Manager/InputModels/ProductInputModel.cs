using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FourWeb.Business.Manager.InputModels
{
    public class ProductInputModel
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int QuantityOnHand { get; set; }
        public int CategoryId { get; set; }        
    }
}
