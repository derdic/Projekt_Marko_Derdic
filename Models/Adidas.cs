using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Models
{
    public class Adidas
    {
        public int Id { get; set; }

        public string Name { get; set; }
        
        public string Size { get; set; }
        
        public decimal Price { get; set; }

    }
}
