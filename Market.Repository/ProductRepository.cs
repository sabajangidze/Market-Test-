using Market.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market.Repository
{
    public class ProductRepository : BaseRepository<Product, int>
    {
        public ProductRepository(MarketDbContext dbContext) : base(dbContext)
        {

        }

        public ProductRepository(string connectionString) : base(connectionString)
        {

        }
    }
}
