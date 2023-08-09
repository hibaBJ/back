using AxiaBackend.Model.Entities;

namespace AxiaBackend.Interfaces
{
    public interface ITypeCongesService
    {
        List<TypeConges> GetAll();

        void Delete(TypeConges prTypeConges);
        TypeConges Save(TypeConges prTypeConges);
    }
}