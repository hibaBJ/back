using AxiaBackend.Interfaces;
using AxiaBackend.Model.Entities;

namespace AxiaBackend.Services
{
    public class LogService : ILogService
    {
        public AppDataContext _context { get; set; }
        public LogService(AppDataContext prAppDataContext)
        {
            _context = prAppDataContext;
        }
        public List<Log> GetAll()
        {
            return _context.Logs.ToList();
        }
        public List<Log> GetByName(string prname)
        {
            var linq = from Log in _context.Logs select Log;
            if (!string.IsNullOrWhiteSpace(prname))
                linq.Where(x => x.Message.ToUpper().Contains(prname.ToUpper()));
            return linq.ToList();
        }
        public Log Save(Log prLog)
        {
            _context.Logs.Add(prLog);
            _context.SaveChanges();
            return prLog;
        }
        public Log Update(Log prLog)
        {
            Log lLogFromDB = _context.Logs.First(x => x.Id == prLog.Id);
            _context.Entry(lLogFromDB).CurrentValues.SetValues(prLog);
            _context.SaveChanges();
            return prLog;
        }
        public void Delete(Log prLog)
        {
            _context.Entry(prLog).State = Microsoft.EntityFrameworkCore.EntityState.Deleted;
            _context.SaveChanges();
        }
    }
}
