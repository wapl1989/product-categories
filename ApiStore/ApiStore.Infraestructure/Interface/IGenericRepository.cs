﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ApiStore.Infraestructure.Interface
{
    public interface IGenericRepository<TEntity>
    {
        public Task<IEnumerable<TEntity>> GetAll();
        public Task<IEnumerable<TEntity>> GetFor(Expression<Func<TEntity, bool>> predicate);
        public Task<bool> SaveEntity(TEntity entity);
        public Task<bool> EditEntity(TEntity entity);
        public Task<bool> DeleteEntity(int id);
        public Task SaveChanges();
    }
}
