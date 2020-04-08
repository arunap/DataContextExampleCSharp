using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System.Threading;
using System.Threading.Tasks;
using DataContextExampleCSharp.Models;

namespace DataContextExampleCSharp.DataContexts
{
    public class DataContext : DbContext, IDataContext
    {
        public DataContext()
        {
            Database.EnsureCreated();
        }
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlite(@"Data Source=D:\\DataContextExampleCSharp.db");
            base.OnConfiguring(options);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CallExtractionProgress>()
            .Property(b => b.CompletedOnUTC)
            .HasDefaultValueSql("date('now')");

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<CallExtractionProgress> CallExtractionProgress { get; set; }

        public override int SaveChanges()
        {
            return base.SaveChanges();
        }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            return base.SaveChangesAsync(cancellationToken);
        }

        public override DbSet<TEntity> Set<TEntity>()
        {
            return base.Set<TEntity>(); 
        }

        public override EntityEntry<TEntity> Entry<TEntity>(TEntity entity)
        { 
            return base.Entry(entity);
        }
    }
}
