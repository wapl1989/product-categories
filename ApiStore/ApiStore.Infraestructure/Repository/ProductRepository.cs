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
using System.Linq.Dynamic.Core;

namespace ApiStore.Infraestructure.Repository
{
    public class ProductRepository : IProductRepository
    {        
        private readonly BDStoreContext _bdStoreContext;
        public ProductRepository(BDStoreContext bdStoreContext) 
        {
            _bdStoreContext = bdStoreContext;
        }

        public async Task<bool> DeleteEntity(int id)
        {
            var productFind = _bdStoreContext.Products.Find(id);
            _bdStoreContext.Entry(productFind).State = EntityState.Deleted;
            await SaveChanges();
            return true;
        }

        public async Task<bool> EditEntity(Product entity)
        {
            var productFind = _bdStoreContext.Products.Find(entity.Id);
            productFind.IdCategorie = entity.IdCategorie;
            productFind.NameProduct = entity.NameProduct;
            productFind.Price = entity.Price;
            productFind.UrlImage = entity.UrlImage;
            productFind.Description = entity.Description;
            _bdStoreContext.Entry(productFind).State = EntityState.Modified;
            await SaveChanges();
            return true;
        }

        public async Task<IEnumerable<Product>> GetAll(string size, string page)
        {
            return await Task.Run(() => _bdStoreContext.Products
                                                    .Skip((PagerHelper.PageNumber(page) - 1) * PagerHelper.PageSize(size))
                                                    .Take(PagerHelper.PageSize(size))
                                                    .ToList());
        }

        public async Task<IEnumerable<Product>> GetAll(string size, string page, string fieldOrder, bool descending = false)
        {
            return await Task.Run(() => _bdStoreContext.Products
                                                    .Skip((PagerHelper.PageNumber(page) - 1) * PagerHelper.PageSize(size))
                                                    .Take(PagerHelper.PageSize(size))
                                                    .OrderBy(PagerHelper.OrderByField(fieldOrder,descending))
                                                    .ToList());
        }

        public async Task<IEnumerable<Product>> GetFor(Expression<Func<Product, bool>> predicate, string size, string page)
        {
            return await Task.Run(() => _bdStoreContext.Products.Where(predicate)
                                                    .Skip((PagerHelper.PageNumber(page) - 1) * PagerHelper.PageSize(size))
                                                    .Take(PagerHelper.PageSize(size))
                                                    .ToList());
        }

        public async Task<IEnumerable<Product>> GetFor(Expression<Func<Product, bool>> predicate, string size, string page, string fieldOrder, bool descending = false)
        {
            return await Task.Run(() => _bdStoreContext.Products.Where(predicate)
                                                    .Skip((PagerHelper.PageNumber(page) - 1) * PagerHelper.PageSize(size))
                                                    .Take(PagerHelper.PageSize(size))
                                                    .OrderBy(PagerHelper.OrderByField(fieldOrder, descending))
                                                    .ToList());
        }

        public async Task SaveChanges()
        {
            await _bdStoreContext.SaveChangesAsync();
        }

        public async Task<bool> SaveEntity(Product entity)
        {
            await _bdStoreContext.Products.AddAsync(entity);
            await SaveChanges();
            return true;
        }
    }
}
