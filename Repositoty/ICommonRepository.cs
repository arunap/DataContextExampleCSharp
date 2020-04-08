using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace DataContextExampleCSharp.Repositoty
{
    public interface ICommonRepository<TEntity> where TEntity : class
    {
        public void Delete(TEntity entityToDelete);
        public void Delete(object id);
        public Task<TEntity> GetByIdAsync(object id);
        public void Insert(TEntity entity);
        public void Update(TEntity entityToUpdate);
        public Task<IEnumerable<TEntity>> GetAsync(Expression<Func<TEntity, bool>> filter = null, Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null, string includeProperties = "");
    }
}
