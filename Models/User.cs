using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace disinterest.Models
{
    public class User
    {
        public int Id { get; set; }

        [StringLength(16, MinimumLength = 3)]
        [Required(ErrorMessage = "Username is required")]
        public string Name { get; set; }

        [DataType(DataType.EmailAddress)]
        [Required(ErrorMessage = "Email is required")]
        public string Email { get; set; }

        [DataType(DataType.Password)]
        [Required (ErrorMessage = "Password is required")]
        public string Password { get; set; }

        [Required]
        [Compare("Password", ErrorMessage ="Please confirm your password.")]
        public string ConfirmPassword { get; set; }

        public ICollection<Product> Products { get; set; }
       
    }
}
