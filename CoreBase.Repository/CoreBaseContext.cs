using CoreBase.Core.Domain;
using JetBrains.Annotations;
using Microsoft.EntityFrameworkCore;

namespace CoreBase.Repositories
{
    public class CoreBaseContext : DbContext
    {
        public CoreBaseContext(DbContextOptions<CoreBaseContext> options) 
            : base(options)
        {
        }

        public virtual DbSet<Value> Values { get; set; }

    }
}
