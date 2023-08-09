using AxiaBackend.Interfaces;
using AxiaBackend.Model.Entities;

namespace AxiaBackend.Services
{
    public class GroupeService : IGroupeService
    {
        public AppDataContext _context { get; set; }
        public GroupeService(AppDataContext prAppDataContext)
        {
            _context = prAppDataContext;
        }
        public List<Groupe> GetAll()
        {
            return _context.Groupes.ToList();
        }
        public List<Groupe> GetByName(string prName)
        {
            var linq =from Groupe in _context.Groupes select Groupe; 
            if(!string.IsNullOrWhiteSpace(prName))
            
                linq=linq.Where(x => x.Name.ToUpper().Contains(prName.ToUpper()));
            
            return linq.ToList();
        }
        public Groupe Save(Groupe prGroupe)
        {
            _context.Groupes.Add(prGroupe);
            _context.SaveChanges();
            return prGroupe;

      
        }
        public Groupe Update(Groupe prGroupe)
        {
            Groupe lGroupeFromDB = _context.Groupes.First(x => x.Id == prGroupe.Id);
            _context.Entry(lGroupeFromDB).CurrentValues.SetValues(prGroupe);
            _context.SaveChanges();
            return prGroupe;
        }
        public void Delete(int cbmarq)
        {
            var entity = _context.Groupes.Find(cbmarq);
            _context.Groupes.Remove(entity);
            
            _context.SaveChanges();
        }
    }
}
