using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mission06_lear99.Models
{
    public class MovieContext : DbContext
    {
 //Constructor method!
        public MovieContext (DbContextOptions<MovieContext> options) : base (options)
        {
            //leave blank for now
        }

        public DbSet<ApplicationResponse> responses { get; set; }

        protected override void OnModelCreating(ModelBuilder mb)
        {
            //seed the database with 3 of my favorite movies
            mb.Entity<ApplicationResponse>().HasData(
                new ApplicationResponse
                {
                    MovieID = 1,
                    Category = "Comedy",
                    Title = "The Three Amigos",
                    Year = 1986,
                    Director = "John Landis",
                    Rating = "PG",
                    Edited = false,
                    LentTo = "N/A",
                    Notes = "Potentially the greatest movie of all time!"
                },
                new ApplicationResponse
                {
                    MovieID = 2,
                    Category = "Action",
                    Title = "The Man From U.N.C.L.E.",
                    Year = 2015,
                    Director = "Guy Ritchie",
                    Rating = "PG-13",
                    Edited = false,
                    LentTo = "N/A",
                    Notes = "A very fun spy movie with good russian!"
                },
                new ApplicationResponse
                {
                    MovieID = 3,
                    Category = "Comedy",
                    Title = "Fantastic Mr. Fox",
                    Year = 2009,
                    Director = "Wes Anderson",
                    Rating = "PG",
                    Edited = false,
                    LentTo = "N/A",
                    Notes = "Wes Anderson movies are amazing!"
                }
                );
        }
    }
}
