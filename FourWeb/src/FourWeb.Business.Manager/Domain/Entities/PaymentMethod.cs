﻿using FourWeb.Abstraction.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FourWeb.Business.Manager.Domain.Entities
{
    public class PaymentMethod : EntityBase
    {
        public int Parcels { get; private set; }
        public int InterestRate { get; private set; }

        protected PaymentMethod()
        {

        }

        public static PaymentMethod Create(int parcels, int interestRate)
        {
            return new PaymentMethod()
            {
                 Parcels = parcels,
                 InterestRate = interestRate
            };
        }
    }
}
