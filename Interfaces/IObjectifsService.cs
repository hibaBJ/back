using AxiaBackend.Model.Entities;

namespace AxiaBackend.Interfaces
{
    public interface IObjectifsService
    {
        void Delete(int cbmarq);
        List<Objectifs> GetAll();
        List<Objectifs> GetByName(string prname);
        Objectifs Save(Objectifs prObjectifs);
        Objectifs Update(Objectifs prObjectifs);
    }
}