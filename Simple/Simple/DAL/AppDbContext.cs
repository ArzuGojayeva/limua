using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Simple.Models;

namespace Simple.DAL
{
    public class AppDbContext: IdentityDbContext<AppUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<About> Abouts { get; set; }
        public DbSet<Slider> Sliders { get; set; }
        public DbSet<Main> Mains { get; set; }
        public DbSet<Questions> Questions { get; set; } 
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<SocialMedia> SocialMedia { get; set; } 

    }
}
