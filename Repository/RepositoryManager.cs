using Contracts;
using Contracts.Repositories;
using Persistence.Context;
using System.Runtime.CompilerServices;

namespace Repository
{


    public class RepositoryManager : IRepositoryManager     /// Quand souligné, aller voir interface
    {
        private ApplicationDbContext _context;

        private readonly Lazy<ICategoryRepository> _lazyCategoryRepository;

        public RepositoryManager(ApplicationDbContext context)
        {
            _lazyCategoryRepository = new Lazy<ICategoryRepository>(() => new CategoryRepository(context));

            _context = context;
        }

        public ICategoryRepository CategoryRepository => _lazyCategoryRepository.Value;

        public async Task<int> Save()
        {
            return await _context.SaveChangesAsync();

        }

    }
}
