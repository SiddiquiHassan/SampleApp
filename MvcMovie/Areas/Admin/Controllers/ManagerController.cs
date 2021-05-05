using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MvcMovie.Areas.Admin.Models;

namespace MvcMovie.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ManagerController : Controller
    {
        public IActionResult Index()
        {
            var movies = new List<Movie>
            {
                new Movie{ Title="Movie1", Genre="Comedy", Id=1, Price=577, ReleaseDate=System.DateTime.Now },
                new Movie{ Title="Movie2", Genre="Thriller", Id=2, Price=588, ReleaseDate=System.DateTime.Now },
                new Movie{ Title="Movie3", Genre="Adventure", Id=3, Price=556, ReleaseDate=System.DateTime.Now }
            };
            return View(movies);
        }

        public IActionResult Edit(int Id)
        {

            return View();
        }

        public List<Movie> List()
        {
            var movies = new List<Movie>
            {
                new Movie{ Title="Movie1", Genre="Comedy", Id=1, Price=577, ReleaseDate=System.DateTime.Now },
                new Movie{ Title="Movie2", Genre="Thriller", Id=2, Price=588, ReleaseDate=System.DateTime.Now },
                new Movie{ Title="Movie3", Genre="Adventure", Id=3, Price=556, ReleaseDate=System.DateTime.Now }
            };

            return movies;
        }
    }
}
