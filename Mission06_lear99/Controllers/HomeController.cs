using Microsoft.AspNetCore.Mvc;
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
        private readonly ILogger<HomeController> _logger;
        private MovieContext _dataContext { get; set; }
        //constructor

        public HomeController(ILogger<HomeController> logger, MovieContext someName)
        {
            _logger = logger;
            _dataContext = someName;
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
            return View();
        }

        //method for saving the movies into the database. I didn't do any error checking here.
        [HttpPost]
        public IActionResult AddMovies(ApplicationResponse response)
        {
            _dataContext.Add(response);
            _dataContext.SaveChanges();
            return View("Confirmation", response);
        }




        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
