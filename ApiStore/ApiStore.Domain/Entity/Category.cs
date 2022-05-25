using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace ApiStore.Domain.Entity
{
    public partial class Category
    {
        public Category()
        {
            Products = new HashSet<Product>();
        }
        public int Id { get; set; }
        public string NameCategorie { get; set; }
        public bool Active { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}
