using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Models
{
    public class Pride
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Ime je obavezno")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Veličina je obavezan")]
        public int Size { get; set; }
        [Required(ErrorMessage = "Cijena je obavezna")]
        public decimal Price { get; set; }

    }

    
}
