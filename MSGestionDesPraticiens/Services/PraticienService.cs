using MSGestionDesPraticiens.Data;
using MSGestionDesPraticiens.Models;

namespace MSGestionDesPraticiens.Services
{
    public class PraticienService : IPraticienService
    {
    private readonly PraticienDbContext _context; // ApplicationDbContext est une classe hypothétique représentant le contexte de base de données

        public PraticienService(PraticienDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Praticien> GetPraticiens()
        {
            return _context.Praticiens.ToList();
        }

        public Praticien GetPraticienById(int id)
        {
            return _context.Praticiens.FirstOrDefault(p => p.Id == id);
        }

        public Praticien CreatePraticien(Praticien praticien)
        {
            _context.Praticiens.Add(praticien);
            _context.SaveChanges();
            return praticien;
        }

        public Praticien UpdatePraticien(int id, Praticien praticien)
        {
            var existingPraticien = _context.Praticiens.FirstOrDefault(p => p.Id == id);

            if (existingPraticien != null)
            {
                existingPraticien.Nom = praticien.Nom;
                // Met à jour d'autres propriétés selon les besoins

                _context.SaveChanges();
            }

            return existingPraticien;
        }

        public Praticien DeletePraticien(int id)
        {
            var praticienToDelete = _context.Praticiens.FirstOrDefault(p => p.Id == id);

            if (praticienToDelete != null)
            {
                _context.Praticiens.Remove(praticienToDelete);
                _context.SaveChanges();
            }

            return praticienToDelete;
        }
    }
}

