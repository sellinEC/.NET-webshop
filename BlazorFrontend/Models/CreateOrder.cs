using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorFrontend.Models
{
    public class CreateOrder
    {
        /*public bool Status { get; set; }*/
        public int UserId { get; set; }


        public virtual ICollection<CreateOrderLines> OrderLines { get; set; }
    }
}
