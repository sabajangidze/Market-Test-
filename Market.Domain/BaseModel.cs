using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market.Domain
{
    public abstract class BaseModel<TKey>
    {
        [Required]
        public TKey ID { get; set; }
    }
}
