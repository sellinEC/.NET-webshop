using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace API.Models
{
    public class CreateCategoryModel
    {
        [Display(Name = "Category name")]
        [Required(ErrorMessage = "{0} must be provided")]
        public string CategoryName { get; set; }
    }
}
