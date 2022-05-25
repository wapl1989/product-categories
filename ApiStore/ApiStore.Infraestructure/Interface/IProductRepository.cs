using ApiStore.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ApiStore.Infraestructure.Interface
{
    public interface IProductRepository : IGenericRepository<Product>
    {
        //public Task<IEnumerable<Product>> GetAllProduct();
        //public Task<IEnumerable<Product>> GetAllProduct(Expression<Func<Product, bool>> predicate);
        //public Task<Product> GetProduct();
        //public Task<bool> SaveProduct();
        //public Task<bool> EditProduct();
        //public Task<bool> DeleteProduct();
        //public Task<int> SaveChangeProduct();
    }
}
