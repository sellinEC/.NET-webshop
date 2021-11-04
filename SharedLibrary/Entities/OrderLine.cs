﻿using System;
using System.Collections.Generic;

#nullable disable

namespace API.Entities
{
    public partial class OrderLine
    {
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public int OrderId { get; set; }

        public virtual Order Order { get; set; }
        public virtual Product Product { get; set; }
    }
}
