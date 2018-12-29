using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BollywoodMoviedb.Models
{
    public class MovieSearchModel
    {
        [StringLength(200)]
        public string SearchCriteria { get; set; }

        public List<MoviesModel> MovieResult { get; set; }
    }
}