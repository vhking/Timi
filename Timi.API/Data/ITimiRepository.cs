using System.Collections.Generic;
using System.Threading.Tasks;
using Timi.API.Helpers;
using Timi.API.Models;

namespace Timi.API.Data
{
    public interface ITimiRepository
    {
        Task<bool> SaveAll();

        void Add<T>(T entity) where T : class;
        void Delete<T>(T entity) where T : class;        
        Task<T> Get<T>(int id) where T : class;

        Task<Photo> GetMainPhotoForUser(int userId);

        Task<IEnumerable<User>> GetUsers();
        Task<IEnumerable<Project>> GetProjects();
        Task<IEnumerable<WorkParticipation>> GetWorkParticipations();

        Task<PagedList<Message>> GetMessageForUser(MessageParams messageParams);
        Task<IEnumerable<Message>> GetMessageThread(int userId, int recipientId);




    }
}