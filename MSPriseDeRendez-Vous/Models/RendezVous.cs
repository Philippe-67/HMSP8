
namespace MSPriseDeRendezVous.Models
{
    public class RendezVous
    {
        public int Id { get; set; }
        public string NamePatient { get; set; }
        public DateTime DateRendezVous { get; set;}
        public string Motif {  get; set; }

        public int PraticienId { get; set; }  // Clé étrangère
        public Praticien Praticien { get; set; }  // Propriété de navigation

    }
}
