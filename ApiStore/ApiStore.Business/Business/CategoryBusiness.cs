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
            return _categoryRepository.DeleteEntity(id);
        }

        public async Task<bool> EditEntity(Category entity)
        {
            return await _categoryRepository.EditEntity(entity);
        }

        public async Task<IEnumerable<Category>> GetAll()
        {
            return await _categoryRepository.GetAll();
        }

        public async Task<IEnumerable<Category>> GetFor(Expression<Func<Category, bool>> predicate)
        {
            return await _categoryRepository.GetFor(predicate);
        }

        public Task<bool> SaveEntity(Category entity)
        {
            return _categoryRepository.SaveEntity(entity);
        }
    }
}
