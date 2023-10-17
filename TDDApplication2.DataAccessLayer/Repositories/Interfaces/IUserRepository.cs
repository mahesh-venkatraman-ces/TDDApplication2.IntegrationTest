using System.Linq.Expressions;
using TDDApplication2.DataAccessLayer.Entities;

namespace TDDApplication2.DataAccessLayer.Repositories.Interfaces
{
    public interface IUserRepository
    {
        User Get(int userid);
        Task<List<User>> GetListAsync();
    }
}
