using API.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace API.Models
{
    public class CreateUserModel
    {
        [Display(Name = "First name")]
        [Required(ErrorMessage = "{0} must be provided")]
        [StringLength(255, ErrorMessage = "{0} must be atleast {2} characters long", MinimumLength =2)]
        public string FirstName { get; set; }
        [Display(Name = "Last name")]
        [Required(ErrorMessage = "{0} must be provided")]
        [StringLength(255, ErrorMessage = "{0} must be atleast {2} characters long", MinimumLength = 2)]
        public string LastName { get; set; }
        [Display(Name = "Email")]
        [Required(ErrorMessage = "{0} must be provided")]
        [RegularExpression("^[a-zA-Z0-9_.-]+@[a-zA-Z0-9-.]+$", ErrorMessage ="{0} must be a valid email adress")]
        public string Email { get; set; }
        [Display(Name = "Password")]
        [Required(ErrorMessage = "{0} must be provided")]
        [DataType(DataType.Password)]
        [RegularExpression(@"^.*(?=.{8,})(?=.*\d)(?=.*[a-z])(?=.*[A-Z])(?=.*[!*@#$%^&+=]).*$", ErrorMessage = "{0} must be 8 chars + special char")]
        public string Password { get; set; }

        //
        /*public int AdressId { get; set; }*/

        // public virtual Adress Adress { get; set; }
    }
}
