using AxiaBackend.Interfaces;
using AxiaBackend.Model.Entities;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace AxiaBackend.Services
{
    public class UserService : IUserService
    {
        public AppDataContext _context { get; set; }
        public UserService(AppDataContext prAppDataContext)
        {
            _context = prAppDataContext;
        }
     
        public User Save(User prUser)
        {
            _context.Users.Add(prUser);
            _context.SaveChanges();
            return prUser;
        }
        public async Task<IEnumerable<User>> Find(Expression<Func<User, bool>> predicate)
        {
            return await _context.Users.Where(predicate).ToListAsync();
        }
    }
}
