using Persistence.Models;
using DataTransfertObject.DTO;

namespace Business.Interface
{
    public interface ICategorieService
    {
        public Task<IEnumerable<CategorieDTO>> RecupererListeCategorie();

        public Task<CategorieDTO>? RecupererCategorieParId(int identifiant);

        public Task<CategorieDTO> CreerCategorie(CategorieDTO categorieDTO);

        public Task<int> SupprimerCategorie(int identifiant);

        public Task<int> ModifierCategorie(CategorieDTO categorieDTO);

    }
}
