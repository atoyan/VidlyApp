using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Newtonsoft.Json;
using VidlyApp.Models;
using VidlyApp.ViewModels;

namespace VidlyApp.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        [Route("movies/random")]
        public ActionResult Random()
        {

            var movieList = new List<Movie>()
            {
                new Movie() {Name = "Shrek"},
                new Movie() {Name = "Wall-e"}
            };

       

            var viewModel = new RandomMovieViewModel
            {
                MovieList = movieList
               
            };
            return View(viewModel); 
      
        }

        [Route("movies")]
        public ActionResult movies()
        {
            var movies = new List<Movie>
            {
                new Movie() {Name = "Shrek"},
                new Movie() {Name = "Wall-e"}
            };
           var moviesList = new RandomMovieViewModel()
            {
                MovieList = movies
            };

            return View(moviesList);
        }

        
              
    
    }
}