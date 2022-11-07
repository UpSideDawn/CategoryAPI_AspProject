using Contracts.RepositoryBase;
using Persistence.Models;


namespace Contracts.Repositories
{
    public interface ICategoryRepository : IRepositoryBase<Categorie>
    {
       /* IQueryable<Categorie> FindAll();

        IQueryable<Categorie> FindByCondition(Expression<Func<T, bool>> expression);

        void Create(Categorie entity);

        void Update(Categorie entity);

        void Delete(Categorie entity);
       */
    }
}
