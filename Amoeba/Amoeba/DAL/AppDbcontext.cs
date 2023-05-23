using Amoeba.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Amoeba.DAL
{
    public class AppDbcontext:IdentityDbContext<AppUser>
    {
        public AppDbcontext(DbContextOptions<AppDbcontext>options):base(options)
        {

        }
        public DbSet<Client>clients { get; set; }
        public DbSet<Profession>Professions { get; set; }
        public DbSet<About> about { get; set; } 
        public DbSet<Slider> slider { get; set; }
        public DbSet<Contact> contacts { get; set; }
        public DbSet<Settingone> services { get; set; }
        public DbSet<Questions> questions { get; set; }
        public DbSet<AppUser> appUsers { get; set; }
        public DbSet<Settings> settings { get; set; }
    }
}
