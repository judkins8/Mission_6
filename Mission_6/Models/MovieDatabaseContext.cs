using Microsoft.EntityFrameworkCore;
using Mission_6.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Threading.Tasks;

namespace Mission_6.Models
{
    public class MovieDatabaseContext : DbContext
    {
        //Constructor
        public MovieDatabaseContext(DbContextOptions<MovieDatabaseContext> options) : base(options)
        {
            //Leave blank for now
        }

        public DbSet<AppRes> Responses { get; set; }

        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<AppRes>().HasData(
                new AppRes
                {
                    ApplicationID = 1,
                    Category = "Crime/Drama",
                    Title = "Pulp Fiction",
                    Year = 1994,
                    Director = "Quentin Tarantino",
                    Rating = "R"
                },
                new AppRes
                {
                    ApplicationID = 2,
                    Category = "War/Action",
                    Title = "Inglourious Basterds",
                    Year = 2009,
                    Director = "Quentin Tarantino",
                    Rating = "R"
                },
                new AppRes
                {
                    ApplicationID = 3,
                    Category = "Western/Drama",
                    Title = "The Hateful Eight",
                    Year = 2015,
                    Director = "Quentin Tarantino",
                    Rating = "R"
                }
            );
        }
    }
}