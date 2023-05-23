using Eterna.Models;
using Microsoft.EntityFrameworkCore;

namespace Eterna.DAL
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext>options):base(options) {

        }   
        public DbSet<Client> Clients { get; set; }
        public DbSet<Profession> Professions { get; set;}

    }
    
}
