using AxiaBackend.Interfaces;
using AxiaBackend.Model.Entities;

namespace AxiaBackend.Services
{
    public class ObjectifsService : IObjectifsService
    {
        public AppDataContext _context { get; set; }
        public ObjectifsService(AppDataContext prAppDataContext)
        {
            _context = prAppDataContext;
        }
        public List<Objectifs> GetAll()
        {
            return _context.Objectifs.ToList();
        }
        public List<Objectifs> GetByName(string prname)
        {
            var linq = from Objectifs in _context.Objectifs select Objectifs;
            if(!string.IsNullOrWhiteSpace(prname))
                linq=linq.Where(x=>x.Projet.ToUpper().Contains(prname.ToUpper()));
            return linq.ToList();
        }
        public Objectifs Save(Objectifs prObjectifs)
        {
            _context.Objectifs.Add(prObjectifs);
            _context.SaveChanges();
            return prObjectifs;
        }
        public Objectifs Update(Objectifs prObjectifs)
        {
            Objectifs lObjectifsFromDB = _context.Objectifs.First(x => x.Id == prObjectifs.Id);
            _context.Entry(lObjectifsFromDB).CurrentValues.SetValues(prObjectifs);
            _context.SaveChanges();
            return prObjectifs;
        }
        public void Delete(int cbmarq)
        {
            var entity = _context.Objectifs.Find(cbmarq);
            _context.Objectifs.Remove(entity);
            
            _context.SaveChanges();
        }
    }
}


