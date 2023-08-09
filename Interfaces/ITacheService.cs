using AxiaBackend.Model.Entities;

namespace AxiaBackend.Interfaces
{
    public interface ITacheService
    {
        void Delete(int cbmarq);
        List<Taches> GetAll();
        List<Taches> GetByName(string prname);
        Taches Save(Taches prTache);
        Taches Update(Taches prTache);
    }
}