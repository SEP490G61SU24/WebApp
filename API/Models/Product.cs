﻿using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class Product
    {
        public Product()
        {
            SaleItems = new HashSet<SaleItem>();
            Categories = new HashSet<Category>();
        }

        public int ProductId { get; set; }
        public int? SpaId { get; set; }
        public string? ProductName { get; set; }
        public string? Description { get; set; }
        public decimal? Price { get; set; }
        public int? QuantityInStock { get; set; }

        public virtual Spa? Spa { get; set; }
        public virtual ICollection<SaleItem> SaleItems { get; set; }

        public virtual ICollection<Category> Categories { get; set; }
    }
}