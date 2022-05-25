using ApiStore.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiStore.Infraestructure.Interface
{
    public interface ICategoryRepository : IGenericRepository<Category>
    {
        
    }
}
