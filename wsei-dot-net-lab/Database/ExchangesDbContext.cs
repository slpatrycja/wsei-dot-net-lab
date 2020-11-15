using Microsoft.EntityFrameworkCore;
using wsei_dot_net_lab.Entities;

namespace wsei_dot_net_lab.Database
{
    public class ExchangesDbContext : DbContext
    {
        public ExchangesDbContext(DbContextOptions options)
            : base(options)
        {
        }
        public DbSet<ItemEntity> Items { get; set; }
    }
}