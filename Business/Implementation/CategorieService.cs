using Persistence.Models;
using DataTransfertObject.DTO;
using Microsoft.EntityFrameworkCore;
using Persistence.Context;
using Business.Interface;
using Repository;
using Contracts;
using Mapster;

namespace Business.Implementation
{
    public class CategorieService : ICategorieService   //Erreur de type ou d'interface
    {
        private IRepositoryManager _repositoryManager;

        //DbContextOptionsBuilder<ApplicationDbContext> _optionBuilder;

        public CategorieService(IRepositoryManager repositoryManager/*CategorieDAL dal, DbContextOptionsBuilder<ApplicationDbContext> optionBuilder*/)
        {
            _repositoryManager = repositoryManager;


        }

        public async Task<IEnumerable<CategorieDTO>> RecupererListeCategorie()
        {
            IEnumerable<Categorie> categorieModelResultat = null;

            //Initialise une variable valable uniquement entre les cotes



            categorieModelResultat = await _repositoryManager.CategoryRepository.FindAll();


            return categorieModelResultat.Adapt<IEnumerable<CategorieDTO>>();
        }

        public async Task<CategorieDTO>? RecupererCategorieParId(int identifiant)
        {
            //IEnumerable<Categorie> categorieModelResultat = null;

            //Initialise une variable valable uniquement entre les cotes

            var categorieFromDb =  await _repositoryManager.CategoryRepository.FindOneByCondition(categorie => categorie.Id.Equals(identifiant));      // ne pas oublier single or default

            if (categorieFromDb == null)
            {
                return null;
            }

            return categorieFromDb.Adapt<CategorieDTO>();
        }

        public async Task<CategorieDTO> CreerCategorie(CategorieDTO categorieDTO)
        {
            //Task<int> categorieCodeRetour = null;

            var categorie = categorieDTO.Adapt<Categorie>();

            _repositoryManager.CategoryRepository.Create(categorie);

            await _repositoryManager.Save();

            return categorieDTO;    //Retourne l'objet venant d'être créer
        }

        public async Task<int> SupprimerCategorie(int identifiant)
        {
            //Task<int> categorieCodeRetour = null;

            var categorieFromDb = await _repositoryManager.CategoryRepository.FindOneByCondition(categorie => categorie.Id.Equals(identifiant));      // ne pas oublier single or default

            if (categorieFromDb == null)
            {
                return -1;
            }

            _repositoryManager.CategoryRepository.Delete(categorieFromDb);

            return await _repositoryManager.Save();

        }
        public async Task<int> ModifierCategorie(CategorieDTO categorieDTO)
        {
            //Task<int> categorieCodeRetour = null;

            //var categorieFromDb = _repositoryManager.CategoryRepository.FindByCondition(categorie => categorie.Id.Equals(identifiant)).SingleOrDefault();

            var categorieAdapted = categorieDTO.Adapt<Categorie>();

            _repositoryManager.CategoryRepository.Update(categorieAdapted);

            return await _repositoryManager.Save();
        }



    }



}
