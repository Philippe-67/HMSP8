using MSPriseDeRendez_Vous;
using MSPriseDeRendezVous.Models;

namespace MSPriseDeRendez_Vous.Services
{
    public interface IRendezVousService
    {
        
    IEnumerable<RendezVous> GetRendezVous();

        RendezVous GetRendezVousById(int id);

        RendezVous CreateRendezVous(RendezVous rendezVous);

        RendezVous UpdateRendezVous(int id, RendezVous rendezVous);

        RendezVous DeleteRendezVous(int id);
    }
}

