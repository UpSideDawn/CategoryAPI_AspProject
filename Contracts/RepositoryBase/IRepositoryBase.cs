using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.RepositoryBase
{
    public interface IRepositoryBase<T>
    {
        Task<IEnumerable<T>> FindAll();

        Task<IEnumerable<T>> FindManyByCondition(Expression<Func<T, bool>> expression);

        Task<T> FindOneByCondition(Expression<Func<T, bool>> expression);

        void Create(T entity);

        void Update(T entity);

        void Delete(T entity);
    }
}
