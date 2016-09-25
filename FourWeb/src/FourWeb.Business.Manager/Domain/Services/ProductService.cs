using FourWeb.Business.Manager.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FourWeb.Business.Manager.Domain.Services
{
    public class ProductService
    {
        private readonly IProductRepository _productRepository;
        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }


    }
}
