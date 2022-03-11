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
        [RegularExpression("@^[a-zA-Z][a-zA-Z0-9]*$")]
        [Required]
        public string Name { get; set; }

        [DataType(DataType.EmailAddress)]
        [Required]
        public string Email { get; set; }

        [DataType(DataType.Password)]
        public string Password { get; set; }

        public ICollection<Product> Products { get; set; }
       
    }
}
