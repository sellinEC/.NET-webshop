using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace API.Models
{
    public class CreateOrderlinesModel
    {
        [Display(Name = "Product Id")]
        [Required(ErrorMessage = "{0} must be provided")]
        public int ProductId { get; set; }
        [Display(Name = "Quantity")]
        [Required(ErrorMessage = "{0} must be provided")]
        public int Quantity { get; set; }
        [Display(Name = "Order Id")]
        [Required(ErrorMessage = "{0} must be provided")]
        public int OrderId { get; set; }
    }
}
