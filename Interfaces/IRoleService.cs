using AxiaBackend.Model.Entities;

namespace AxiaBackend.Interfaces
{
    public interface IRoleService
    {
        void Delete(int cbmarq);
        List<Role> GetAll();
        List<Role> GetByName(string prName);

        Role Save(Role prRole);
        Role Update(Role prRole);
    }
}