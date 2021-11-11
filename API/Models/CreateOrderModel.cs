using API.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Models
{
    public  class CreateOrderModel
    {
    
        public int Id { get; set; }
        public bool Status { get; set; }
        public int UserId { get; set; }

        
        public virtual ICollection<CreateOrderlinesModel> OrderLines { get; set; }
    }
}

