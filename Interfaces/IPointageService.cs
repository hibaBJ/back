using AxiaBackend.Model.Entities;

namespace AxiaBackend.Interfaces
{
    public interface IPointageService
    {
        void Delete(int cbmarq);
        List<Pointage> GetAll();
        List<Pointage> GetByName(string prname);
        Pointage Save(Pointage prPointage);
        Pointage Update(Pointage prPointage);
    }
}