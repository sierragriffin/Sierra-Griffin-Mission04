//Connection to Database

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;

namespace Mission04Assignment.Models
{
    public class MovieContext : DbContext
    {
        //Constructor
        public MovieContext(DbContextOptions<MovieContext> options) : base(options)
        {
            //Leave Blank for now
        }

        public DbSet<AddMovieResponse> Responses { get; set; }

        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<AddMovieResponse>().HasData(
                    //Seeding Database
                    new AddMovieResponse
                    {
                        MovieId = 1,
                        Category = "Sci-fi",
                        Title = "Back to the Future",
                        Year = 1985,
                        Director = "Robert Zemeckis",
                        Rating = "PG"
                    },
                    new AddMovieResponse
                    {
                        MovieId = 2,
                        Category = "Musical",
                        Title = "Little Shop of Horrors",
                        Year = 1986,
                        Director = "Frank Oz",
                        Rating = "PG-13"
                    },
                    new AddMovieResponse
                    {
                        MovieId = 3,
                        Category = "Horror/Thriller",
                        Title = "Halloween",
                        Year = 1978,
                        Director = "John Carpenter",
                        Rating = "R",
                        Edited = true
                    }
                );
        }
    }
}
