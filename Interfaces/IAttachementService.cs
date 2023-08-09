using AxiaBackend.Model.Entities;

namespace AxiaBackend.Interfaces
{
    public interface IAttachementService
    {

        string Upload(IFormFile file);
        void Delete(int cbmarq);
        List<Attachements> GetAll();
        List<Attachements> GetByName(string prname);
        List<Attachements> GetByName();
        Attachements Save(Attachements prAttachements);
        Attachements Update(Attachements prAttachements);
    }
}