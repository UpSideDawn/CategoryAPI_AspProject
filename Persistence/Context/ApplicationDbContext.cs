using Microsoft.EntityFrameworkCore;
using Persistence.Models;

namespace Persistence.Context
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Categorie> Categories { get; set; }    //Initialise l'objet Categories de type Categorie (Contentant les champs du model)

    }
}
