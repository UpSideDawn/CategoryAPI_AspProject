using Business.Interface;
using Contracts;

namespace Business.Implementation
{
    public class ServiceManager : IServiceManager
    {
        private readonly Lazy<ICategorieService> _lazyCategorieService;


        public ServiceManager(IRepositoryManager repositoryManager)
        {
            _lazyCategorieService = new Lazy<ICategorieService>(() => new CategorieService(repositoryManager));


        }

        public ICategorieService CategorieService => _lazyCategorieService.Value;
    }
}
