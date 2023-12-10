using Microsoft.EntityFrameworkCore;
using MSPriseDeRendezVous.Models;
using System.Collections.Generic;

namespace MSPriseDeRendez_Vous.Data
{
    public class RendezVousDbContext : DbContext
    {
        public RendezVousDbContext(DbContextOptions<RendezVousDbContext> options) : base(options)
        {
        }

        public DbSet<RendezVous> RendezVous { get; set; }
    }
   
}
