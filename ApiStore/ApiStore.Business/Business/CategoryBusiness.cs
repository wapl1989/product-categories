using ApiStore.Business.Interface;
using ApiStore.Domain.Entity;
using ApiStore.Infraestructure.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ApiStore.Business.Business
{
    public class CategoryBusiness : ICategoryBusiness
    {
        private readonly ICategoryRepository _categoryRepository;
        public CategoryBusiness(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        public Task<bool> DeleteEntity(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> EditEntity(Category entity)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Category>> GetAll()
        {
            return await _categoryRepository.GetAll();
        }

        public Task<IEnumerable<Category>> GetFor(Expression<Func<Category, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public Task<bool> SaveEntity(Category entity)
        {
            throw new NotImplementedException();
        }
    }
}
