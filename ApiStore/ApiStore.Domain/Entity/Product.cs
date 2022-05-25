using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace ApiStore.Domain.Entity
{
    public partial class Product
    {
        
        public int Id { get; set; }
        public string NameProduct { get; set; }
        public string Description { get; set; }
        public string UrlImage { get; set; }
        public int IdCategorie { get; set; }
        public decimal Price { get; set; }

        public virtual Category IdCategorieNavigation { get; set; }
    }
}
