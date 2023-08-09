using AxiaBackend.Interfaces;
using AxiaBackend.Model.Entities;
using AxiaBackend.View;

namespace AxiaBackend.Services
{
    public class CongesService : ICongesService

    {
        public AppDataContext _context { get; set; }
        public CongesService(AppDataContext prAppDataContext)
        {
            _context = prAppDataContext;
        }
        public List<ViewConge> GetAll()
        {
            return _context.ViewConge.ToList();
        }
        public List<Conges> GetByName(string prname)
        {
            var linq = from Conges in _context.Conges select Conges;
            if (!string.IsNullOrWhiteSpace(prname))
                linq.Where(x => x.Employee.ToUpper().Contains(prname.ToUpper()));
            return linq.ToList();
        }
        public Conges Save(Conges prConges)
        {
            _context.Conges.Add(prConges);
            _context.SaveChanges();
            return prConges;
        }
        public Conges Update(Conges prConges)
        {
            Conges lCongesFromDB = _context.Conges.First(x => x.Id == prConges.Id);
            _context.Entry(lCongesFromDB).CurrentValues.SetValues(prConges);
            _context.SaveChanges();
            return prConges;
        }
        public void Delete(int cbmarq)
        {
            var entity = _context.Conges.Find(cbmarq);
            _context.Conges.Remove(entity);
            
            _context.SaveChanges();
        }
    }
}




