using Canopee.Domain.Contracts;

using Microsoft.EntityFrameworkCore;

using System.Linq.Expressions;

namespace Canopee.Persistence
{
    public abstract class RepositoryBase<T> : IRepositoryBase<T> where T : class
    {
        protected RepositoryContext RepositoryContext;

        public RepositoryBase(RepositoryContext repositoryContext) => RepositoryContext = repositoryContext;

        public void Create(T entity) => RepositoryContext.Set<T>().Add(entity);

        public void Delete(T entity) => RepositoryContext.Set<T>().Remove(entity);

        public void Update(T entity) => RepositoryContext.Set<T>().Update(entity);

        public IQueryable<T> FindAll(bool trackChanges) => GetQueryable(trackChanges);
        public IQueryable<T> FindByCondition(Expression<Func<T, bool>> expression, bool trackChanges) => GetQueryable(trackChanges).Where(expression);

        private IQueryable<T> GetQueryable(bool trackChanges) => trackChanges ? RepositoryContext.Set<T>() : RepositoryContext.Set<T>().AsNoTracking();

    }
}
