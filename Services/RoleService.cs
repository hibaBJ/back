using AxiaBackend.Interfaces;
using AxiaBackend.Model.Entities;

namespace AxiaBackend.Services
{
    public class RoleService : IRoleService
    {
        public AppDataContext _context { get; set; }
        public RoleService(AppDataContext prAppDataContext)
        {
            _context = prAppDataContext;
        }
        public List<Role> GetAll()
        {
            return _context.Roles.ToList();
        }
        public List<Role> GetById(string prName)
        {
            var linq = from Role in _context.Roles select Role;
            if (!string.IsNullOrWhiteSpace(prName))
                linq.Where(x => x.role.ToUpper().Contains(prName.ToUpper()));
            return linq.ToList();
        }
        public Role Save(Role prRole)
        {
           _context.Roles.Add(prRole);
            _context.SaveChanges();
            return prRole;
        }
        public Role Update(Role prRole)
        {
            Role lRoleFromDB = _context.Roles.First(x => x.Id == prRole.Id);
            _context.Entry(lRoleFromDB).CurrentValues.SetValues(prRole);
            _context.SaveChanges();
            return prRole;
        }
        public void Delete(int cbmarq)
        {
            var entity = _context.Roles.Find(cbmarq);
            _context.Roles.Remove(entity);
            
            _context.SaveChanges();
        }
        public List<Role> GetByName(string prName)
        {
            throw new NotImplementedException();
        }
    }
}

