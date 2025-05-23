using Microsoft.EntityFrameworkCore;
using sql_server_webapp.Models.Entities; // inherit dbcontext class

namespace sql_server_webapp.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options) 
        {           
            
        }
        public DbSet<Student> Students { get; set; }
    }
}
