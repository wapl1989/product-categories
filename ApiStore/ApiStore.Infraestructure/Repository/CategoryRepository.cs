using ApiStore.Domain.Entity;
using ApiStore.Infraestructure.Data;
using ApiStore.Infraestructure.Helper;
using ApiStore.Infraestructure.Interface;
using Microsoft.EntityFrameworkCore;
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

        public async Task<bool> DeleteEntity(int id)
        {
            var Find = _bdStoreContext.Categories.Find(id);
            _bdStoreContext.Entry(Find).State = EntityState.Deleted;
            await SaveChanges();
            return true;
        }

        public async Task<bool> EditEntity(Category entity)
        {
            var Find = _bdStoreContext.Categories.Find(entity.Id);
            Find.NameCategorie = entity.NameCategorie;
            Find.Active = entity.Active;
            _bdStoreContext.Entry(Find).State = EntityState.Modified;
            await SaveChanges();
            return true;
        }

        public async Task<IEnumerable<Category>> GetAll(string size, string page)
        {
            return await Task.Run(() => _bdStoreContext.Categories
                                                    .Skip((PagerHelper.PageNumber(page) - 1) * PagerHelper.PageSize(size))
                                                    .Take(PagerHelper.PageSize(size))
                                                    .ToList());
        }

        public async Task<IEnumerable<Category>> GetFor(Expression<Func<Category, bool>> predicate, string size, string page)
        {
            return await Task.Run(() => _bdStoreContext.Categories.Where(predicate)
                                                    .Skip((PagerHelper.PageNumber(page) - 1) * PagerHelper.PageSize(size))
                                                    .Take(PagerHelper.PageSize(size))
                                                    .ToList());
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
