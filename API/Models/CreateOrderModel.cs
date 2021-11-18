using API.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace API.Models
{
    public  class CreateOrderModel
    {
    
        public int Id { get; set; }
        
        public bool Status { get; set; }
        [Display(Name = "User Id")]
        [Required(ErrorMessage = "{0} must be provided")]
        public int UserId { get; set; }

        
        public virtual ICollection<CreateOrderlinesModel> OrderLines { get; set; }
    }
}

