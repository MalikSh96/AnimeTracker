using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.IO;
using AnimeTracker.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace AnimeTracker.Models
{
    //public class DataContext : IdentityDbContext
    public class DataContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json");

            var configuration = builder.Build();
            optionsBuilder.UseMySql(configuration["ConnectionStrings:DefaultConnection"]);
        }

        //This is a reference to your table content
        public DbSet<Anime> Animes { get; set; }

        //This is a reference to your table content
        public DbSet<AppUser> User { get; set; }
    }
}
