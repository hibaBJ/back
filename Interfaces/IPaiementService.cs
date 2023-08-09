using AxiaBackend.Model.Entities;

namespace AxiaBackend.Interfaces
{
    public interface IPaiementService
    {
        void Delete(int cbmarq);
        List<Paiement> GetAll();
        List<Paiement> GetByName(string prname);
        Paiement Save(Paiement prPaiement);
        Paiement Update(Paiement prPaiement);
    }
}