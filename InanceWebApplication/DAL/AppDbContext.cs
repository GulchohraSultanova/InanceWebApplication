using InanceWebApplication.Models;
using Microsoft.EntityFrameworkCore;

namespace InanceWebApplication.DAL
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options) {

        }
        public DbSet<Comments> Comments { get; set; }
        public DbSet<Services> Services { get; set; }
       
    }
}
