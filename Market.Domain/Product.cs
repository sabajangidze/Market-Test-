using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market.Domain
{
    public class Product : BaseModel<int>
    {
        [Required]
        [MaxLength(20)]
        public string Name { get; set; }

        [Required]
        public double InputPrice { get; set; }

        [Required]
        public double OutPrice { get; set; }

        [Required]
        [MaxLength(35)]
        public string Description { get; set; }

        [Required]
        [MaxLength(12)]
        public string Barcode { get; set; }

        public Category Category { get; set; }

        public Supplier Supplier { get; set; }

    }
}
