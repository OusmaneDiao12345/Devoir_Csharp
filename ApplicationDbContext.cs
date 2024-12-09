using Microsoft.EntityFrameworkCore;

namespace GestionCoursAbsences.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        // Vos DbSet pour les entités
        public DbSet<Classe> Classes { get; set; }
        public DbSet<Professeur> Professeurs { get; set; }
        public DbSet<Cours> Cours { get; set; }
        public DbSet<Etudiant> Etudiants { get; set; }
        public DbSet<Absence> Absences { get; set; }
    }
}
