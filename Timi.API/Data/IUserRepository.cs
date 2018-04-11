using System.Collections.Generic;
using System.Threading.Tasks;
using Timi.API.Models;

namespace Timi.API.Data
{
    public interface IUserRepository
    {
        Task<User> GetAsync(int id);
        Task<IEnumerable<User>> GetAllAsync();
        Task AddAsync(User project);
        Task DeleteAsync(User project);
    }
}