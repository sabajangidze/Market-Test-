using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market.Domain
{
    public class Supplier : BaseModel<int>
    {
        [Required]
        [MaxLength(20)]
        public string CompanyName { get; set; }

        public IEnumerable<Product> Products { get; set; }
    }
}
