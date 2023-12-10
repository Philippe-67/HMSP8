// Dans le dossier Services de MSPriseDeRendezVous

using MSPriseDeRendez_Vous.Data;
using MSPriseDeRendez_Vous;
using System.Collections.Generic;
using MSPriseDeRendezVous.Models;
using MSPriseDeRendez_Vous.Services;

public class RendezVousService : IRendezVousService
{
    private readonly RendezVousDbContext _context;

    public RendezVousService(RendezVousDbContext context)
    {
        _context = context;
    }

    public RendezVousService()
    {
    }

    public IEnumerable<RendezVous> GetRendezVous()
    {
        return _context.RendezVous.ToList();
    }

    public RendezVous GetRendezVousById(int id)
    {
        return _context.RendezVous.FirstOrDefault(r => r.Id == id);
    }

    public RendezVous CreateRendezVous(RendezVous rendezVous)
    {
        if (rendezVous == null)
        {
            throw new ArgumentNullException(nameof(rendezVous));
        }

        _context.RendezVous.Add(rendezVous);
        _context.SaveChanges();

        return rendezVous;
    }

    //public RendezVous UpdateRendezVous(int id, RendezVous rendezVous)
    //{
    //    if (rendezVous == null)
    //    {
    //        throw new ArgumentNullException(nameof(rendezVous));
    //    }

    //    var existingRendezVous = _context.RendezVous.FirstOrDefault(r => r.Id == id);

    //    if (existingRendezVous == null)
    //    {
    //        return null; // Not found
    //    }

    //    existingRendezVous.Date = rendezVous.Date;
    //    existingRendezVous.Description = rendezVous.Description;

    //    _context.SaveChanges();

    //    return existingRendezVous;
    //}

    public RendezVous DeleteRendezVous(int id)
    {
        var rendezVousToDelete = _context.RendezVous.FirstOrDefault(r => r.Id == id);

        if (rendezVousToDelete != null)
        {
            _context.RendezVous.Remove(rendezVousToDelete);
            _context.SaveChanges();
        }

        return rendezVousToDelete;
    }

    public RendezVous UpdateRendezVous(int id, RendezVous rendezVous)
    {
        throw new NotImplementedException();
    }
}

