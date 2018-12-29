using BollywoodMovie.Core.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BollywoodMovie.Core.Repository
{
    public interface IMovieRepository : IRepository<Movie>
    {
        IEnumerable<Movie> SearchMovies(string criteria);
    }

}
