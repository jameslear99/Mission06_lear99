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

        public DbSet<Movie> Movies { get; set; }

        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<Category>().HasData(
                new Category { CategoryID = 1, CategoryName="Comedy"},
                new Category { CategoryID = 2, CategoryName = "Action" },
                new Category { CategoryID = 3, CategoryName = "Romance" },
                new Category { CategoryID = 4, CategoryName = "Drama" },
                new Category { CategoryID = 5, CategoryName = "Horror" },
                new Category { CategoryID = 6, CategoryName = "Other" }
                );

            //seed the database with 3 of my favorite movies
            mb.Entity<Movie>().HasData(
                new Movie
                {
                    MovieID = 1,
                    CategoryID = 1,
                    Title = "The Three Amigos",
                    Year = 1986,
                    Director = "John Landis",
                    Rating = "PG",
                    Edited = false,
                    LentTo = "N/A",
                    Notes = "Potentially the greatest movie of all time!"
                },
                new Movie
                {
                    MovieID = 2,
                    CategoryID = 2,
                    Title = "The Man From U.N.C.L.E.",
                    Year = 2015,
                    Director = "Guy Ritchie",
                    Rating = "PG-13",
                    Edited = false,
                    LentTo = "N/A",
                    Notes = "A very fun spy movie with good russian!"
                },
                new Movie
                {
                    MovieID = 3,
                    CategoryID = 1,
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
