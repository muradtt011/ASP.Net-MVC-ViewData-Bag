using ClassPractise.Models;
using Microsoft.EntityFrameworkCore;

namespace ClassPractise.DAL
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Student> Students { get; set; }

        public DbSet<Group> Groups { get; set; }
     }
    
}
 