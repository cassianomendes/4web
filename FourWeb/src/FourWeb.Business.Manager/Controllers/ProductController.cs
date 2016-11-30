using AutoMapper;
using FourWeb.Business.Manager.Domain.Entities;
using FourWeb.Business.Manager.Domain.Services;
using FourWeb.Business.Manager.InputModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FourWeb.Business.Manager.Controllers
{
    [Route("api/[controller]")]
    public class ProductController : Controller
    {
        private readonly ProductService _service;
        private readonly IMapper _mapper;
        public ProductController(ProductService service, IMapper mapper)
        {
            _mapper = mapper;
            _service = service;            
        }

        [HttpPost]
        public IActionResult Post([FromBody]ProductInputModel inputModel)
        {
            _service.Create(_mapper.Map<Product>(inputModel));
            return Ok();
        }

        [HttpPut("{id:int}")]
        public IActionResult Put(int id, [FromBody]ProductInputModel inputModel)
        {
            _service.Update(_mapper.Map<Product>(inputModel));
            return Ok();
        }
    }
}
