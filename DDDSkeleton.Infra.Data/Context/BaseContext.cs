using DDDSkeleton.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace DDDSkeleton.Infra.Data.Context
{
    public class BaseContext : DbContext
    {
        public DbSet<ItemList> ItemsList { get; set; }
        public DbSet<ItemList> Items { get; set; }

        public BaseContext(DbContextOptions optionsBuilder)
            : base(optionsBuilder)
        {
        }

        public BaseContext()
        {
        }
    }
}
