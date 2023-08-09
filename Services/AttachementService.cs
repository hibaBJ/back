using AxiaBackend.Interfaces;
using AxiaBackend.Model.Entities;
using Microsoft.EntityFrameworkCore;
using System.Net.Http.Headers;
using System.Xml.Linq;

namespace AxiaBackend.Services
{
    public class AttachementService : IAttachementService
    {

        public AppDataContext _context { get; set; }
        public AttachementService(AppDataContext prAppDataContext)
        {
            _context = prAppDataContext;
        }


        public string Upload(IFormFile file)
        {
            string Pathfile = "";
            Pathfile = "C:\\Users\\B J\\source\\repos\\uploadfile";
            var folderName = Path.Combine(Pathfile);
            var LastPath = Path.GetFullPath(@"Resources\Images\");


            var pathToSave = Path.Combine(Directory.GetCurrentDirectory(), folderName);
            if (file.Length > 0)
            {
                var fileName = ContentDispositionHeaderValue.Parse(file.ContentDisposition).FileName.Trim('"');
                var fullPath = Path.Combine(pathToSave, fileName);
                var dbPath = Path.Combine(folderName, fileName);
                LastPath = fileName;
                using (var stream = new FileStream(fullPath, FileMode.Create))
                {
                    file.CopyTo(stream);
                }
            }
            return LastPath;

        }

        public List<Attachements> GetAll()
        {
            return _context.Attachements.ToList();
        }

        public Attachements Save(Attachements prAttachements)
        {
            _context.Attachements.Add(prAttachements);
            _context.SaveChanges();
            return prAttachements;
        }
        public Attachements Update(Attachements prAttachements)
        {
            Attachements lAttachementFromDB = _context.Attachements.First(x => x.CbMarq == prAttachements.CbMarq);
            _context.Entry(lAttachementFromDB).CurrentValues.SetValues(prAttachements);
            _context.SaveChanges();
            return prAttachements;
        }
        public void Delete(int cbmarq)
        {
            var entity = _context.Attachements.Find(cbmarq);
            _context.Attachements.Remove(entity);
            //_context.Entry(prAttachements).State = Microsoft.EntityFrameworkCore.EntityState.Deleted;
            _context.SaveChanges();
        }

        public List<Attachements> GetByName(string prName)
        {
            var linq = from Attachements in _context.Attachements select Attachements;
            if (!string.IsNullOrWhiteSpace(prName))
                linq = linq.Where(x => x.Employee.ToUpper().Contains(prName.ToUpper()));
            return linq.ToList();
        }

        public List<Attachements> GetByName()
        {
            throw new NotImplementedException();
        }
    }
}
