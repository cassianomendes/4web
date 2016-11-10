using FourWeb.Business.Report.Domain.Entities;
using FourWeb.Business.Report.Domain.Repositories;
using System;
using System.Collections.Generic;

namespace FourWeb.Business.Report.Domain.Services
{
    public class OrderService
    {
        private readonly IOrderRepositoryQuery _orderRepositoryQuery;
        private readonly ICustomerRepositoryQuery _customerRepositoryQuery;

        public OrderService(IOrderRepositoryQuery orderRepositoryQuery, ICustomerRepositoryQuery customerRepositoryQuery)
        {
            _orderRepositoryQuery = orderRepositoryQuery;
            _customerRepositoryQuery = customerRepositoryQuery;
        }

        public IEnumerable<Order> GetAll(string email)
        {
            var customer = _customerRepositoryQuery.GetByEmail(email);
            return _orderRepositoryQuery.GetAll(customer.Id);
        }

        public IEnumerable<Order> GetLatestOrders(string email)
        {
            var customer = _customerRepositoryQuery.GetByEmail(email);
            return _orderRepositoryQuery.GetLatestOrders(customer.Id);
        }

        public IEnumerable<Order> GetByDate(string email, DateTime date)
        {
            var customer = _customerRepositoryQuery.GetByEmail(email);
            return _orderRepositoryQuery.GetByDate(customer.Id, date);
        }

        public Order GetById(int orderId)
        {
            return _orderRepositoryQuery.GetById(orderId);
        }
    }
}
