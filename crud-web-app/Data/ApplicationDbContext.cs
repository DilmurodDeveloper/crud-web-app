using crud_web_app.Models;
using Microsoft.EntityFrameworkCore;

namespace crud_web_app.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            :base(options)
        { 
        }

        public DbSet<Client> Clients { get; set; } 
    }
}
