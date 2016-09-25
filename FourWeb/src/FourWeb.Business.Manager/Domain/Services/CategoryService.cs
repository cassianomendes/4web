using FourWeb.Abstraction.Domain.Services;
using FourWeb.Business.Manager.Domain.Entities;
using FourWeb.Business.Manager.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FourWeb.Business.Manager.Domain.Services
{
    public class CategoryService : CommandService<Category>
    {
        private readonly ICategoryRepository _categoryRepository;
        public CategoryService(ICategoryRepository categoryRepository)
            : base(categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        public override void Update(Category model)
        {
            var category = _categoryRepository.GetById(model.Id);
            category.UpdateTitle(model.Title);
            base.Update(category);
        }
    }
}
