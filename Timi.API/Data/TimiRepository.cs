using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using Timi.API.Helpers;
using Timi.API.Models;

namespace Timi.API.Data
{
    public class TimiRepository : ITimiRepository
    {
        private readonly IConfiguration _configuration;
        public TimiRepository(IConfiguration configuration)
        {
            _configuration = configuration;

        }
        private string GetConnection()
        {
            var connection = _configuration.GetSection("ConnectionStrings").GetSection("DefaultConnection").Value;

            return connection;
        }
        public void Add<T>(T entity) where T : class
        {
            // var connectionString = this.GetConnection();
            // using (var con = new SqlConnection(connectionString))
            // {
            //     try
            //     {
            //         con.Open();
            //         var query = "INSERT INTO [entity]"
            //     }
            //     catch (System.Exception)
            //     {
                    
            //         throw;
            //     }
            // }
        }

        public void Delete<T>(T entity) where T : class
        {
            throw new System.NotImplementedException();
        }

        public Task<T> Get<T>(int id) where T : class
        {
            throw new System.NotImplementedException();
        }

        public Task<Photo> GetMainPhotoForUser(int userId)
        {
            throw new System.NotImplementedException();
        }

        public Task<PagedList<Message>> GetMessageForUser(MessageParams messageParams)
        {
            throw new System.NotImplementedException();
        }

        public Task<IEnumerable<Message>> GetMessageThread(int userId, int recipientId)
        {
            throw new System.NotImplementedException();
        }

        public Task<IEnumerable<Project>> GetProjects()
        {
            throw new System.NotImplementedException();
        }

        public Task<IEnumerable<User>> GetUsers()
        {
            throw new System.NotImplementedException();
        }

        public Task<IEnumerable<WorkParticipation>> GetWorkParticipations()
        {
            throw new System.NotImplementedException();
        }

        public Task<bool> SaveAll()
        {
            throw new System.NotImplementedException();
        }
    }
}