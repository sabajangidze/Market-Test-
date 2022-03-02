using Market.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market.Repository
{
    public class CategoryRepository : BaseRepository<Category, int>
    {
        public CategoryRepository(MarketDbContext dbContext) : base(dbContext)
        {

        }

        public CategoryRepository(string connectionString) : base(connectionString)
        {

        }
    }
}
