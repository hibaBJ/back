using AxiaBackend.Model.Entities;
using System.Linq.Expressions;

namespace AxiaBackend.Interfaces
{
    public interface IUserService
    {
   
        User Save(User prUser);
        Task<IEnumerable<User>> Find(Expression<Func<User, bool>> predicate);


    }
}