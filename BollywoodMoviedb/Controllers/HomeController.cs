using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using BollywoodMoviedb.Models;

namespace BollywoodMoviedb.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ViewResult SearchMovies(MovieSearchModel model)
        {
            return View("Index",GetMoviesDetails());
        }


        private MovieSearchModel GetMoviesDetails()
        {
           
            var movieList = new List<MoviesModel>();

            for (int i=0;i<108;i++)
            {
                movieList.Add(GetSingleMovie());
            }

            return new MovieSearchModel { MovieResult = movieList };
           
        }

        private MoviesModel GetSingleMovie()
        {
            return new MoviesModel
            {
                Name = "Sarkar 3",
                Year = "2017",
                Overview = "Subhash Nagre or Sarkar, the patriarch of the most powerful family of Maharashtra, continues to hold centre-stage because of his immense clout " +
                "with the masses. In this outing, the Godfather is joined by his grandson Shivaji Nagre who loves and hates his grandfather with equal intensity. Will Shivaji " +
                "betray Subhash? Or will he become a prey to his grandfather’s machinations?",
                ImageUrl = "https://image.tmdb.org/t/p/w1280/uiVSElM8JNz4zK3p6K01SWuk8dD.jpg",
                Genres="Action",
                Actors = new string[] { "Amitabh Bacchan","Jacki Shroff"}.ToList(),
                TrailerURL=""
            };
        }
    }
}
