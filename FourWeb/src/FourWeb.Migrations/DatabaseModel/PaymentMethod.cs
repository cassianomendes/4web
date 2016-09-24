using FourWeb.Abstraction.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FourWeb.DatabaseModel
{
    public class PaymentMethod : EntityBase
    {
        public int Parcels { get; private set; }
        public int InterestRate { get; private set; }       
    }
}
