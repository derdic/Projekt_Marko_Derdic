using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Shop.Models
{
    public class Login
    {
        [Display(Name = "Korisničko ime")]
        [Required(ErrorMessage = "User name je obavezan")]
        public string UserName { get; set; }
        [Display(Name = "Lozinka")]
        [Required(ErrorMessage = "Lozinka je obavezna")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
