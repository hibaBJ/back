using AxiaBackend.Model.Entities;

namespace AxiaBackend.Interfaces
{
    public interface ILogService
    {
        void Delete(Log prLog);
        List<Log> GetAll();
        List<Log> GetByName(string prname);
        Log Save(Log prLog);
        Log Update(Log prLog);
    }
}