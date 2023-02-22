using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Mission06_lear99.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Mission06_lear99.Controllers
{
    public class HomeController : Controller
    {

        private MovieContext dataContext { get; set; }
        //constructor

        public HomeController(MovieContext someName)
        {
            dataContext = someName;
        }

        public IActionResult Index()
        {
            return View();
        }


        public IActionResult MyPodcasts()
        {
            return View();
        }

        //method for showing the add movies page
        [HttpGet]
        public IActionResult AddMovies()
        {
            ViewBag.Categories = dataContext.Categories.ToList();
            return View();
        }

        //method for saving the movies into the database. I didn't do any error checking here.
        [HttpPost]
        public IActionResult AddMovies(Movie response)
        {
            if (ModelState.IsValid)
            {
                dataContext.Add(response);
                dataContext.SaveChanges();
                return View("Confirmation", response);
            }
            else
            {
                ViewBag.Categories = dataContext.Categories.ToList();
                return View(response);
            }

            
        }

        //this is the action to list all the movies currently stored in the database
        public IActionResult ListMovies()
        {
            var movies = dataContext.Movies
                .Include(x=> x.Category)
                .OrderBy(x=> x.Title)
                .ToList();

            return View(movies);
        }





        //These actions handle the editing functionalities for the website
        [HttpGet]
        public IActionResult Edit(int movieid)
        {
            ViewBag.Categories = dataContext.Categories.ToList();

            var movie = dataContext.Movies.Single(x=> x.MovieID == movieid);
            return View("AddMovies", movie);
        }

        [HttpPost]
        public IActionResult Edit (Movie updatedMovie)
        {
            dataContext.Update(updatedMovie);
            dataContext.SaveChanges();

            return RedirectToAction("ListMovies");
        }





        //These actions handle the deleting functionalities for the website
        [HttpGet]
        public IActionResult Delete (int movieid)
        {
            var movie = dataContext.Movies.Single(x => x.MovieID == movieid);
            return View(movie);
        }

        [HttpPost]
        public IActionResult Delete(Movie deletedMovie)
        {
            dataContext.Movies.Remove(deletedMovie);
            dataContext.SaveChanges();

            return RedirectToAction("ListMovies");
        }
    }
}
