using Market.Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market.Repository
{
    public class MarketDbContext : DbContext
    {
        public MarketDbContext() : base(@"Server =.\SqlExpress; Database = Market_Test; integrated security = true")
        {

        }

        public MarketDbContext(string connectionString = @"Server =.\SqlExpress; Database = Market_Test; integrated security = true") : base(connectionString)
        {

        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
    }
}
