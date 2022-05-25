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
            throw new NotImplementedException();
        }

        public Task<bool> EditEntity(Product entity)
        {
            return _productRepository.EditEntity(entity);
        }

        public async Task<IEnumerable<Product>> GetAll()
        {
            return await _productRepository.GetAll();
        }

        public async Task<IEnumerable<Product>> GetFor(Expression<Func<Product, bool>> predicate)
        {
            return await _productRepository.GetFor(predicate);
        }

        public Task<bool> SaveEntity(Product entity)
        {
            return _productRepository.SaveEntity(entity);
        }        
    }
}
