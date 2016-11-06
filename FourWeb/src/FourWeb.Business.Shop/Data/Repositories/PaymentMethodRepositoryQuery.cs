using FourWeb.Abstraction.Data.Repositories;
using FourWeb.Business.Shop.Data.Contexts;
using FourWeb.Business.Shop.Domain.Entities;
using FourWeb.Business.Shop.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FourWeb.Business.Shop.Data.Repositories
{
    public class PaymentMethodRepositoryQuery : RepositoryQueryBase<PaymentMethod>, IPaymentMethodRepositoryQuery
    {
        public PaymentMethodRepositoryQuery(ShopContext context)
            : base(context)
        {

        }
    }
}
