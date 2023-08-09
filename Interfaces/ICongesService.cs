using AxiaBackend.Model.Entities;
using AxiaBackend.View;

namespace AxiaBackend.Interfaces
{
    public interface ICongesService
    {
        void Delete(int cbmarq);
        List<ViewConge> GetAll();
        List<Conges> GetByName(string prname);
        Conges Save(Conges prConges);
        Conges Update(Conges prConges);
    }
}