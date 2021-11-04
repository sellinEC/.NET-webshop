﻿using System;
using System.Collections.Generic;

#nullable disable

namespace API.Entities
{
    public partial class Product
    {
        public Product()
        {
            OrderLines = new HashSet<OrderLine>();
        }

        public int Id { get; set; }
        public int CategoryId { get; set; }
        public string ProductName { get; set; }
        public string ShortDescription { get; set; }
        public string LongDescription { get; set; }
        public string ImgUrl { get; set; }
        public decimal? Price { get; set; }
        public bool InStock { get; set; }

        public virtual Category Category { get; set; }
        public virtual ICollection<OrderLine> OrderLines { get; set; }
    }
}
