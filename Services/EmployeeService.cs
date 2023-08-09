using AxiaBackend.Interfaces;
using AxiaBackend.Model.Entities;

namespace AxiaBackend.Services
{
    public class EmployeeService : IEmployeeService
    {

        public AppDataContext _context { get; set; }
        public EmployeeService(AppDataContext prAppDataContext)
        {
            _context = prAppDataContext;
        }
        public List<Employee> GetAll()
        {
            return _context.Employees.ToList();
        }
        public List<Employee> GetByName(string prname)

        {
            var linq = from Employees in _context.Employees select Employees;
            if (!string.IsNullOrWhiteSpace(prname))
            {
                linq = linq.Where(x => x.Name.ToUpper().Contains(prname.ToUpper()));
            }

            return linq.ToList();
        }
        public Employee Save(Employee prEmployee)
        {
            _context.Employees.Add(prEmployee);
            _context.SaveChanges();
            return prEmployee;
        }
        public Employee Update(Employee prEmployee)
        {
            Employee lEmployeeFromDB = _context.Employees.First(x => x.Id == prEmployee.Id);
            _context.Entry(lEmployeeFromDB).CurrentValues.SetValues(prEmployee);
            _context.SaveChanges();
            return prEmployee;
        }
        public void Delete(int cbmarq)
        {
            var entity = _context.Employees.Find(cbmarq);
            _context.Employees.Remove(entity);

            _context.SaveChanges();
        }
    }
}


