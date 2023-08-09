using AxiaBackend.Interfaces;
using AxiaBackend.Model.Entities;

namespace AxiaBackend.Services
{
    public class PointageService : IPointageService
    {
        public AppDataContext _context { get; set; }
        public PointageService(AppDataContext prAppDataContext)
        {
            _context = prAppDataContext;
        }
        public List<Pointage> GetAll()
        {
            return _context.Pointages.ToList();
        }
        public List<Pointage> GetByName(string prname)
        {
            var linq = from Pointage in _context.Pointages select Pointage;
            if (!string.IsNullOrWhiteSpace(prname))

                linq = linq.Where(x => x.Employee.ToUpper().Contains(prname.ToUpper()));
            return linq.ToList();

        }
        public Pointage Save(Pointage prPointage)
        {
            _context.Pointages.Add(prPointage);
            _context.SaveChanges();
            return prPointage;
        }
        public Pointage Update(Pointage prPointage)
        {
            Pointage lPointageFromDB = _context.Pointages.First(x => x.Id == prPointage.Id);
            _context.Entry(lPointageFromDB).CurrentValues.SetValues(prPointage);
            _context.SaveChanges();
            return lPointageFromDB;

        }
        public void Delete(int cbmarq)
        {
            var entity = _context.Pointages.Find(cbmarq);
            _context.Pointages.Remove(entity);
            _context.SaveChanges();
        }
    }
}