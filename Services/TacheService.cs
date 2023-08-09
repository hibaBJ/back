using AxiaBackend.Interfaces;
using AxiaBackend.Model.Entities;

namespace AxiaBackend.Services
{
    public class TacheService : ITacheService
    {
        public AppDataContext _context { get; set; }
        public TacheService(AppDataContext prAppDataContext)
        {
            _context = prAppDataContext;
        }
        public List<Taches> GetAll()
        {
            return _context.Taches.ToList();
        }
        public List<Taches> GetByName(string prname)
        {
            var linq = from Taches in _context.Taches select Taches;
            if (!string.IsNullOrWhiteSpace(prname))
                linq.Where(x => x.Nom.ToUpper().Contains(prname.ToUpper()));
            return linq.ToList();
        }
        public Taches Save(Taches prTache)
        {
           _context.Taches.Add(prTache);
            _context.SaveChanges();
            return prTache;
        }
        public Taches Update(Taches prTache)
        {
            Taches lTacheFromDb = _context.Taches.First(x => x.Id == prTache.Id);
            _context.Entry(lTacheFromDb).CurrentValues.SetValues(prTache.Id);
            _context.SaveChanges();
            return prTache;
        }
        public void Delete(int cbmarq)
        {
            var entity = _context.Taches.Find(cbmarq);
            _context.Taches.Remove(entity);
            
            _context.SaveChanges();
        }
    }
}


