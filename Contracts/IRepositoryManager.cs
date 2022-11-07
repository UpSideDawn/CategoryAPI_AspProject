using Contracts.Repositories;


namespace Contracts
{
    public interface IRepositoryManager
    {
        ICategoryRepository CategoryRepository { get; }

        Task<int> Save();
    }
}
