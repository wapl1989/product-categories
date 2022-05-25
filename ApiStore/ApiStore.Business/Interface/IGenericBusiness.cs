using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiStore.Business.Interface
{
    public interface IGenericBusiness<TEntity>
    {
        public Task<IEnumerable<TEntity>> GetAll();
    }
}
