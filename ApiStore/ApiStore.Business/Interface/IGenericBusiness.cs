using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ApiStore.Business.Interface
{
    public interface IGenericBusiness<TEntity>
    {       
        public Task<IEnumerable<TEntity>> GetAll(string size, string page, string fieldOrder, bool descending = false);
        public Task<IEnumerable<TEntity>> GetFor(Expression<Func<TEntity, bool>> predicate, string size, string page, string fieldOrder, bool descending = false);
        public Task<bool> SaveEntity(TEntity entity);
        public Task<bool> EditEntity(TEntity entity);
        public Task<bool> DeleteEntity(int id);
    }
}
