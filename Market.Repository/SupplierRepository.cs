using Market.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market.Repository
{
    public class SupplierRepository : BaseRepository<Supplier, int>
    {
        public SupplierRepository(MarketDbContext dbContext) : base(dbContext)
        {

        }

        public SupplierRepository(string connectionString) : base(connectionString)
        {

        }
    }
}
