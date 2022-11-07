using Microsoft.EntityFrameworkCore;
using Persistence.Context;
using System.Linq.Expressions;

namespace Contracts.RepositoryBase
{
    public class RepositoryBase<T> : IRepositoryBase<T> where T : class
    {
        protected ApplicationDbContext ApplicationDbContext { get; set; }
        public RepositoryBase(ApplicationDbContext applicationDbContext)
        {
            ApplicationDbContext = applicationDbContext;
        }

        public async Task<IEnumerable<T>> FindAll() => await ApplicationDbContext.Set<T>().AsNoTracking().ToListAsync();

        public async Task<T> FindOneByCondition(Expression<Func<T, bool>> expression) =>
            await ApplicationDbContext.Set<T>().Where(expression).AsNoTracking().FirstOrDefaultAsync();

        public async Task<IEnumerable<T>> FindManyByCondition(Expression<Func<T, bool>> expression) =>
            await ApplicationDbContext.Set<T>().Where(expression).AsNoTracking().ToListAsync();
        public void Create(T entity) => ApplicationDbContext.Set<T>().Add(entity);

        public void Update(T entity) => ApplicationDbContext.Set<T>().Update(entity);

        public void Delete(T entity) => ApplicationDbContext.Set<T>().Remove(entity);

    }
}
