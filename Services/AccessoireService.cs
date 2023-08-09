using AxiaBackend.Interfaces;
using AxiaBackend.Model.Entities;

namespace AxiaBackend.Services
{
    public class AccessoireService : IAccessoireService
    {
        public AppDataContext _context { get; set; }
        public AccessoireService(AppDataContext prAppDataContext)
        {
            _context = prAppDataContext;
        }
        public List<Accessoires> GetAll()
        {
            return _context.Accessoires.ToList();

        }
        public List<Accessoires> GetByName(string prName)
        {
            var linq = from Accessoires in _context.Accessoires select Accessoires;
            if (!string.IsNullOrWhiteSpace(prName))
            {
                linq = linq.Where(x => x.Employee.ToUpper().Contains(prName.ToUpper()));
            }
            return linq.ToList();
        }
        public Accessoires Save(Accessoires prAccessoire)
        {
            _context.Accessoires.Add(prAccessoire);
            _context.SaveChanges();
            return prAccessoire;
        }
        public Accessoires Update(Accessoires prAccessoire)
        {
            Accessoires lAccessoireFromDB = _context.Accessoires.First(x => x.Id == prAccessoire.Id);
            _context.Entry(lAccessoireFromDB).CurrentValues.SetValues(prAccessoire);
            _context.SaveChanges();
            return prAccessoire;
        }
        public void Delete(int cbmarq)
        {
            var entity = _context.Accessoires.Find(cbmarq);
            _context.Accessoires.Remove(entity);
           
            _context.SaveChanges();
        }


    }
}
