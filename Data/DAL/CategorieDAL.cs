using Persistence.Context;
using Persistence.Models;
using DataTransfertObject;
using Microsoft.EntityFrameworkCore;

namespace Data.DAL
{
    public class CategorieDAL
    {
        public async Task<IEnumerable<Categorie>> GetAllCategorie(ApplicationDbContext context)
        {
            return await context.Categories.ToListAsync();
        }

        public async Task<Categorie> GetCategorieById(ApplicationDbContext context, int id)
        {
            var categorie = await context.Categories.FindAsync(id);

           /*  if (categorie == null)
             {
                 return new Categorie();                 //Plusieurs return = bonne pratique. Ici renvoie un objet vide en cas d'etagere null
             }
            */
            return categorie;
        }
    }
}
