using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market.Domain
{
    public class Category : BaseModel<int>
    {
        [Required]
        public string CategoryName { get; set; }

        public IEnumerable<Product> Products { get; set; }
    }
}
