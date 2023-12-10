

using MSPriseDeRendezVous.Models;

namespace MSGestionDesPraticiens.Models
{
    public class Praticien
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public string SpecialiteMedicale { get; set; }

        // Relation inverse pour accéder aux rendez-vous associés au praticien
        public List<RendezVous> RendezVous { get; set; } = new List<RendezVous>();
    }
}

