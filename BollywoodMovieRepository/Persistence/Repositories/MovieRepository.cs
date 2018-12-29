using BollywoodMovie.Core.Domain;
using BollywoodMovie.Core.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BollywoodMovie.Persistence.Repository
{
    public class MovieRepository : Repository<Movie>, IMovieRepository
    {
        public MovieRepository(MovieContext context) : base(context)
        { 

        }

        public IEnumerable<Movie> SearchMovies(string criteria)
        {
            return MovieContext.Movies.OrderByDescending(c => c.ToString()).ToList();
        }

        public MovieContext MovieContext
        {
            get { return _context as MovieContext; }
        }

    }
}
