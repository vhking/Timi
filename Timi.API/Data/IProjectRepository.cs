using System.Collections.Generic;
using System.Threading.Tasks;
using Timi.API.Models;

namespace Timi.API.Data
{
    public interface IProjectRepository
    {
         Task<Project> GetAsync(int id);
         Task<IEnumerable<Project>> GetAllAsync();
         Task AddAsync(Project project);
         Task DeleteAsync(Project project);    
    }
}