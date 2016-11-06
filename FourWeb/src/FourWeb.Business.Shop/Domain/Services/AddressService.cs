using FourWeb.Abstraction.Domain.Services;
using FourWeb.Business.Shop.Domain.Entities;
using FourWeb.Business.Shop.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FourWeb.Business.Shop.Domain.Services
{
    public class AddressService : QueryService<Address>
    {
        private readonly IAddressRepositoryQuery _queryRepository;
        public AddressService(IAddressRepositoryQuery queryRepository)
            : base(queryRepository)
        {
            _queryRepository = queryRepository;
        }
    }
}
