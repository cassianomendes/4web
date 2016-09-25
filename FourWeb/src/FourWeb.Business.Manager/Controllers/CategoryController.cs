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
    public class CategoryController : Controller
    {
        private readonly CategoryService _service;
        private readonly IMapper _mapper;
        public CategoryController(CategoryService service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        [HttpPost]
        public IActionResult Post([FromBody]CategoryInputModel inputModel)
        {
            _service.Create(_mapper.Map<Category>(inputModel));
            return Ok();
        }

        [HttpPut("{id:int}")]
        public IActionResult Put(int id, [FromBody]CategoryInputModel inputModel)
        {
            _service.Update(Category.Create(id, inputModel.Title));
            return Ok();
        }
    }
}