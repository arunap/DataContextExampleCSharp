using DataContextExampleCSharp.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace DataContextExampleCSharp.DataContexts
{
    public interface IDataContext : IDisposable
    {
        public int SaveChanges();
        public Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
        public Microsoft.EntityFrameworkCore.DbSet<CallExtractionProgress> CallExtractionProgress { get; set; }
        public DbSet<TEntity> Set<TEntity>() where TEntity : class;
        public Microsoft.EntityFrameworkCore.ChangeTracking.EntityEntry<TEntity> Entry<TEntity>(TEntity entity) where TEntity : class;
    }
}
