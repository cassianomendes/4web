using FourWeb.Abstraction.Domain.Interfaces.Repositories;
using FourWeb.Business.Report.Domain.Entities;
using System;
using System.Collections.Generic;

namespace FourWeb.Business.Report.Domain.Repositories
{
    public interface IOrderRepositoryQuery : IRepositoryQueryBase<Order>
    {
        IEnumerable<Order> GetAll(int customerId);
        IEnumerable<Order> GetLatestOrders(int customerId);
        IEnumerable<Order> GetByDate(int customerId, DateTime date);
    }
}
