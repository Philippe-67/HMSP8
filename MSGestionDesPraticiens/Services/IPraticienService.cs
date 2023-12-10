using MSGestionDesPraticiens.Models;

namespace MSGestionDesPraticiens.Services
{
    public interface IPraticienService
    {
        IEnumerable<Praticien> GetPraticiens();
        Praticien GetPraticienById(int id);
        Praticien CreatePraticien(Praticien praticien);
        Praticien UpdatePraticien(int id, Praticien praticien);
        Praticien DeletePraticien(int id);
    }
}
