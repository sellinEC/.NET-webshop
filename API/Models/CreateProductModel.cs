﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Models
{
    public class CreateProductModel
    {
        public int CategoryId { get; set; }
        public string ProductName { get; set; }
        public string ShortDescription { get; set; }
        public string LongDescription { get; set; }
        public string ImgUrl { get; set; }
        public decimal? Price { get; set; }
        public bool InStock { get; set; }
    }
}
