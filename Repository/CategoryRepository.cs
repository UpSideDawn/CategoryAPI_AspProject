using Contracts.Repositories;
using Contracts.RepositoryBase;
using Persistence.Context;
using Persistence.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class CategoryRepository : RepositoryBase<Categorie>, ICategoryRepository   // EtagereRepository : RepositoryBase<Etagere> ....
    {
        public CategoryRepository(ApplicationDbContext applicationDbContext) : base(applicationDbContext)
        {

        }

        // Si code particulier au category repository, le mettre ici
    }
}
