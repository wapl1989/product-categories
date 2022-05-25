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
    public class ProductBusiness : IProductBusiness
    {
        private readonly IProductRepository _productRepository;
        public ProductBusiness(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public Task<bool> DeleteEntity(int id)
        {
            return _productRepository.DeleteEntity(id);
        }

        public Task<bool> EditEntity(Product entity)
        {
            return _productRepository.EditEntity(entity);
        }

        public async Task<IEnumerable<Product>> GetAll(string size, string page, string fieldOrder, bool descending = false)
        {
            return String.IsNullOrEmpty(fieldOrder) 
                ? await _productRepository.GetAll(size, page) 
                : await _productRepository.GetAll(size, page, fieldOrder, descending);
        }        

        public async Task<IEnumerable<Product>> GetFor(Expression<Func<Product, bool>> predicate, string size, string page, string fieldOrder, bool descending = false)
        {
            return String.IsNullOrEmpty(fieldOrder)
                ? await _productRepository.GetFor(predicate, size, page)
                : await _productRepository.GetFor(predicate, size, page, fieldOrder, descending);
        }

        public Task<bool> SaveEntity(Product entity)
        {
            return _productRepository.SaveEntity(entity);
        }        
    }
}
