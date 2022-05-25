using ApiStore.Domain.Entity;
using ApiStore.Infraestructure.Data;
using ApiStore.Infraestructure.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ApiStore.Infraestructure.Repository
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly BDStoreContext _bdStoreContext;
        public CategoryRepository(BDStoreContext bdStoreContext)
        {
            _bdStoreContext = bdStoreContext;
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
            return await Task.Run(() => _bdStoreContext.Categories.ToList());
        }

        public async Task<IEnumerable<Category>> GetFor(Expression<Func<Category, bool>> predicate)
        {
            return await Task.Run(() => _bdStoreContext.Categories.Where(predicate).ToList());
        }

        public async Task SaveChanges()
        {
            await _bdStoreContext.SaveChangesAsync();
        }

        public async Task<bool> SaveEntity(Category entity)
        {
            await _bdStoreContext.Categories.AddAsync(entity);
            await SaveChanges();
            return true;
        }
    }
}
