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
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<Category>().HasData(
                    new Category { CategoryId = 1, CategoryName = "Action/Adventure" },
                    new Category { CategoryId = 2, CategoryName = "Sci-Fi" },
                    new Category { CategoryId = 3, CategoryName = "Comedy" },
                    new Category { CategoryId = 4, CategoryName = "Romance" },
                    new Category { CategoryId = 5, CategoryName = "Documentary" },
                    new Category { CategoryId = 6, CategoryName = "Other" }
                );

            mb.Entity<AppRes>().HasData(
                new AppRes
                {
                    ApplicationID = 1,
                    CategoryId = 6,
                    Title = "Pulp Fiction",
                    Year = 1994,
                    Director = "Quentin Tarantino",
                    Rating = "R"
                },
                new AppRes
                {
                    ApplicationID = 2,
                    CategoryId = 1,
                    Title = "Inglourious Basterds",
                    Year = 2009,
                    Director = "Quentin Tarantino",
                    Rating = "R"
                },
                new AppRes
                {
                    ApplicationID = 3,
                    CategoryId = 6,
                    Title = "The Hateful Eight",
                    Year = 2015,
                    Director = "Quentin Tarantino",
                    Rating = "R"
                }
            );
        }
    }
}