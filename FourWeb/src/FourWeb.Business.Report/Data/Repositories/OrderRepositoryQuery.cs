using FourWeb.Abstraction.Data.Repositories;
using FourWeb.Business.Report.Data.Contexts;
using FourWeb.Business.Report.Domain.Entities;
using FourWeb.Business.Report.Domain.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FourWeb.Business.Report.Data.Repositories
{
    public class OrderRepositoryQuery : RepositoryQueryBase<Order>, IOrderRepositoryQuery
    {
        public OrderRepositoryQuery(ReportContext context)
            : base(context)
        {
        }

        public IEnumerable<Order> GetAll(int customerId)
        {
            return Entity.AsNoTracking()
                .Where(x => x.CustomerId == customerId);
        }

        public IEnumerable<Order> GetByDate(int customerId, DateTime date)
        {
            return Entity.AsNoTracking()
                .Where(x => x.CustomerId == customerId && x.Date == date);
        }

        public IEnumerable<Order> GetLatestOrders(int customerId)
        {
            return Entity.AsNoTracking()
                .Where(x => x.CustomerId == customerId)
                .OrderByDescending(x => x.Date)
                .Take(3);
        }
    }
}
