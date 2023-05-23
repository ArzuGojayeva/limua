using LUMİA.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace LUMİA.DAL
{
    public class AppDbContext:IdentityDbContext<AppUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext>options):base(options) 
        {

        }
        public DbSet<CustomService> Services { get; set; }
        
        public DbSet<Team> Teams { get; set; }
        public DbSet<WhatWeDo> Whats { get; set; }
        public DbSet<Slider> Slider { get; set; }
        public DbSet<Settings> Settings { get; set; }

    }
}
