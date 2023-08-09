using AxiaBackend.Interfaces;
using AxiaBackend.Model.Entities;

namespace AxiaBackend.Services
{
    public class PaiementService : IPaiementService
    {
        public AppDataContext _context { get; set; }
        public PaiementService(AppDataContext prAppDataContext)
        {
            _context = prAppDataContext;
        }
        public List<Paiement> GetAll()
        {
            return _context.Paiements.ToList();
        }
        public List<Paiement> GetByName(string prname)
        {
            var linq = from Paiement in _context.Paiements select Paiement;
            if (!string.IsNullOrWhiteSpace(prname))
            {
                linq.Where(x => x.Employee.ToUpper().Contains(prname.ToUpper()));
            }
            return linq.ToList();
        }
        public Paiement Save(Paiement prPaiement)
        {
            _context.Paiements.Add(prPaiement);
            _context.SaveChanges();
            return prPaiement;
        }
        public Paiement Update(Paiement prPaiement)
        {
            Paiement lPaiementFromDB = _context.Paiements.First(x => x.Id == prPaiement.Id);
            _context.Entry(lPaiementFromDB).CurrentValues.SetValues(prPaiement);
            _context.SaveChanges();
            return prPaiement;


        }
        public void Delete(int cbmarq)
        {
            var entity = _context.Paiements.Find(cbmarq);
            _context.Paiements.Remove(entity);

            _context.SaveChanges();
        }
    }
}

