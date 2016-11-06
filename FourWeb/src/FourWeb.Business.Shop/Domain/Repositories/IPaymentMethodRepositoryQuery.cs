using FourWeb.Abstraction.Domain.Interfaces.Repositories;
using FourWeb.Business.Shop.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FourWeb.Business.Shop.Domain.Repositories
{
    public interface IPaymentMethodRepositoryQuery : IRepositoryQueryBase<PaymentMethod>
    {
    }
}
