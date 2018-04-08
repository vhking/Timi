using Microsoft.EntityFrameworkCore;

namespace Timi.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) 
            : base(options) {}
        
    }
}