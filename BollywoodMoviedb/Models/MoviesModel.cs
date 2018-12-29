using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BollywoodMoviedb.Models
{
    public class MoviesModel
    {
        public string Name { get; set; }

        public string Overview { get; set; }

        public string Year { get; set; }

        public string Genres { get; set; }

        public string ImageUrl { get; set; }
        public List<string> Actors { get; set; }

        public string TrailerURL { get; set; }
    }
}