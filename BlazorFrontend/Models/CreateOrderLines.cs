using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorFrontend.Models
{
    public class CreateOrderLines
    {
        public int ProductId { get; set; }
        public int Quantity { get; set; }
    }
}
