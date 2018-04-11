using System.Collections.Generic;
using System.Data.SqlClient;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Timi.API.Models;
using Dapper;

namespace Timi.API.Data
{
    public class ProjectRepository : IProjectRepository
    {
        private readonly IConfiguration _configuration;
        public ProjectRepository(IConfiguration configuration)
        {
            _configuration = configuration;

        }
        // gets the connectionstring from appsettings.json
        private string GetConnection()
        {
            var connection = _configuration.GetSection("ConnectionStrings")
                                           .GetSection("DefaultConnection")
                                           .Value;
            return connection;
        }

        public async Task<Project> GetAsync(int id)
        {
            /**
              --Using the using statement will compile the code to:

              var db = new SqlConnection(connectionString);
              try{
                  // code
              }finally{
                  if(db != null) db.Dispose();
              }

              -- Which guarantees that even if an exception occures, the 
              -- Dispose method will be called.
                -- If a catch is needed, it could be nested with a try statement
           */
            var connectionString = this.GetConnection();
            using (var db = new SqlConnection(connectionString))
            {
                string query = @"SELECT *
                                 FROM [Project]
                                 WHERE [Id] = @Id";
                var project = await db.QueryFirstOrDefaultAsync<Project>(query, new { @Id = id });

                return project;
            }
        }

        public Task AddAsync(Project project)
        {
            throw new System.NotImplementedException();
        }

        public Task DeleteAsync(Project project)
        {
            throw new System.NotImplementedException();
        }

        public async Task<IEnumerable<Project>> GetAllAsync()
        {
            var connectionString = this.GetConnection();
            using (var db = new SqlConnection(connectionString))
            {
                string query = @"SELECT *
                                 FROM [Project]";                                
                var project = await db.QueryAsync<Project>(query);

                return project;
            }
        }


    }
}