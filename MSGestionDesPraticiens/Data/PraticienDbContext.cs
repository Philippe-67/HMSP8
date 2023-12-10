using Microsoft.EntityFrameworkCore;
using MSGestionDesPraticiens.Models;
using System.Collections.Generic;

namespace MSGestionDesPraticiens.Data
{
    public class PraticienDbContext:DbContext
    {
        public PraticienDbContext(DbContextOptions<PraticienDbContext> options) : base(options)
        {
        }

        // Ajoute ici les DbSet pour tes entités (par exemple, Praticien)
        public DbSet<Praticien> Praticiens { get; set; }

        // Ajoute d'autres DbSet pour les entités supplémentaires selon les besoins
    }
}
