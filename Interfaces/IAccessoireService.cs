using AxiaBackend.Model.Entities;

namespace AxiaBackend.Interfaces
{
    public interface IAccessoireService
    {

        List<Accessoires> GetAll();
        List<Accessoires> GetByName(string prname);
        Accessoires Save(Accessoires prAccessoire);
        Accessoires Update(Accessoires prAccessoire);
        void Delete(int cbmarq);
    }
}