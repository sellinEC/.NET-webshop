using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace API.Models
{
    public class CreateProductModel
    {
        //Valideras i controllern

/*        [Display(Name = "Category Id")]
        [Required(ErrorMessage = "{0} must be provided")]*/
        public int CategoryId { get; set; }
/*        [Display(Name = "Product name")]
        [Required(ErrorMessage = "{0} must be provided")]
        [StringLength(255, ErrorMessage = "{0} must be atleast {2} characters long", MinimumLength = 2)]*/
        public string ProductName { get; set; }
/*        [Display(Name = "Short description")]
        [Required(ErrorMessage = "{0} must be provided")]
        [StringLength(255, ErrorMessage = "{0} must be atleast {2} characters long", MinimumLength = 50)]*/
        public string ShortDescription { get; set; }
    /*    [Display(Name = "Long description")]
        [Required(ErrorMessage = "{0} must be provided")]
        [StringLength(255, ErrorMessage = "{0} must be atleast {2} characters long", MinimumLength = 100)]*/
        public string LongDescription { get; set; }
/*        [Display(Name = "Image url")]
        [Required(ErrorMessage = "{0} must be provided")]*/
        public string ImgUrl { get; set; }
        public decimal? Price { get; set; }
        public bool InStock { get; set; }
    }
}
