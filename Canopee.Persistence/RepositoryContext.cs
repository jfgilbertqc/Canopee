using Canopee.Domain.Entities;
using Canopee.Persistence.Configuration;

using Microsoft.EntityFrameworkCore;

namespace Canopee.Persistence
{
    public class RepositoryContext : DbContext
    {
        public RepositoryContext(DbContextOptions options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new TreeConfiguration());
        }

        public DbSet<Tree>? Companies { get; set; }
    }
}
