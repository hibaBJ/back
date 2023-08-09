using AxiaBackend.Model.Entities;

namespace AxiaBackend.Interfaces
{
    public interface IGroupeService
    {
        void Delete(int cbmarq);
        List<Groupe> GetAll();
        List<Groupe> GetByName(string prname);
        Groupe Save(Groupe prGroupe);
        Groupe Update(Groupe prGroupe);
    }
}