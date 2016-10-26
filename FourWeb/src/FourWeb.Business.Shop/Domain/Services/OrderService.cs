using FourWeb.Business.Shop.Domain.Entities;
using FourWeb.Business.Shop.Domain.Repositories;

namespace FourWeb.Business.Shop.Domain.Services
{
    public class OrderService
    {
        private readonly IOrderRepositoryQuery _orderRepositoryQuery;

        public OrderService(IOrderRepositoryQuery orderRepositoryQuery)
        {
            _orderRepositoryQuery = orderRepositoryQuery;
        }

        public Order GetById(int id)
        {
            return _orderRepositoryQuery.GetById(id);
        }
    }
}
