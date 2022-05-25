using ApiStore.Business.Models;
using ApiStore.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ApiStore.Business.Filters
{
    public partial class FiltersBusiness
    {
        public static Expression<Func<Product, bool>> ContainsInProduct(ProductFiltersModel filters)
        {
            Expression<Func<Product, bool>> predicate = c => true;
            predicate = (p => p.Description.Contains(filters.Description) 
                            || p.NameProduct.Contains(filters.NameProduct)
                            || p.IdCategorieNavigation.NameCategorie.Contains(filters.NameCategory));
            
            return predicate;
        }

        public static Expression<Func<Category, bool>> ContainsInCategory(CategoryFiltersModel filters)
        {
            Expression<Func<Category, bool>> predicate = c => true;
            predicate = (p => p.NameCategorie.Contains(filters.NameCategory));

            return predicate;
        }
    }
}
