using AxiaBackend.Interfaces;
using AxiaBackend.Model.Entities;
using Microsoft.AspNetCore.Mvc;

namespace AxiaBackend.Services
{
    public class TypeCongesService : ITypeCongesService
    {
        public AppDataContext _context { get; set; }
        public TypeCongesService(AppDataContext prAppDataContext)
        {
            _context = prAppDataContext;
        }
        public List<TypeConges> GetAll()
        {
            return _context.TypeConges.ToList();
        }
        //public List<TypeConges> GetByName(string prName)
        //{
        //    var linq = from TypeConges in _context.TypeConges select TypeConges;
        //    if (!string.IsNullOrWhiteSpace(prName))
        //    {
        //        linq = linq.Where(x => x.Type.ToUpper().Contains(prName.ToUpper()));
        //    }
        //    return linq.ToList();
        //}
        public TypeConges Save(TypeConges prTypeConges)
        {
            _context.TypeConges.Add(prTypeConges);
            _context.SaveChanges();
            return prTypeConges;
        }
        public void Delete(TypeConges prTypeConges)
        {
            _context.Entry(prTypeConges).State = Microsoft.EntityFrameworkCore.EntityState.Deleted;
            _context.SaveChanges();

        }
    }
}
