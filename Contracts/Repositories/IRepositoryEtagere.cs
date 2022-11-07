/*using Persistence.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.Repositories
{
    public interface IRepositoryEtagere
    {
        IQueryable<Etagere> FindAll();

        IQueryable<Etagere> FindByCondition(Expression<Func<T, bool>> expression);

        void Create(Etagere entity);

        void Update(Etagere entity);

        void Delete(Etagere entity);
    }
}
*/