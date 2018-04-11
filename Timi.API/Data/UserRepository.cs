using System.Collections.Generic;
using System.Threading.Tasks;
using Timi.API.Models;

namespace Timi.API.Data
{
    public class UserRepository : IUserRepository
    {
        public Task AddAsync(User project)
        {
            throw new System.NotImplementedException();
        }

        public Task DeleteAsync(User project)
        {
            throw new System.NotImplementedException();
        }

        public Task<IEnumerable<User>> GetAllAsync()
        {
            throw new System.NotImplementedException();
        }

        public Task<User> GetAsync(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}