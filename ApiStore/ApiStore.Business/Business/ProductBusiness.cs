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
        public Task<bool> DeleteProduct()
        {
            throw new NotImplementedException();
        }

        public Task<bool> EditProduct()
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Product>> GetAllProduct()
        {
            return await _productRepository.GetAll();
        }

        public async Task<IEnumerable<Product>> GetAllProduct(Expression<Func<Product, bool>> predicate)
        {
            return await _productRepository.GetFor(predicate);
        }

        public Task<Product> GetProduct()
        {
            throw new NotImplementedException();
        }

        public Task<int> SaveChangeProduct()
        {
            throw new NotImplementedException();
        }

        public Task<bool> SaveProduct()
        {
            throw new NotImplementedException();
        }
    }
}
