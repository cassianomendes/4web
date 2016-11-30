using FourWeb.Abstraction.Domain.Services;
using FourWeb.Business.Manager.Domain.Entities;
using FourWeb.Business.Manager.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FourWeb.Business.Manager.Domain.Services
{
    public class ProductService : CommandService<Product>
    {
        private readonly IProductRepository _productRepository;
        public ProductService(IProductRepository productRepository)
            : base(productRepository)
        {
            _productRepository = productRepository;
        }
    }
}
