using BollywoodMovie.Core.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BollywoodMovie.Core
{
    public interface IUnitOfWork : IDisposable
    {
        IMovieRepository Movies { get; }
        int Complete();
    }
}
