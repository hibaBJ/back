using AxiaBackend.Model.Entities;

namespace AxiaBackend.Interfaces
{
    public interface IEmployeeService
    {
        void Delete(int cbmarq);
        List<Employee> GetAll();
        List<Employee> GetByName(string prname);
        Employee Save(Employee prEmployee);
        Employee Update(Employee prEmployee);
    }
}