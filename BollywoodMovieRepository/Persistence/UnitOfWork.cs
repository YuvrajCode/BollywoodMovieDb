using BollywoodMovie.Core;
using BollywoodMovie.Core.Repository;
using BollywoodMovie.Persistence.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BollywoodMovie.Persistence
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly MovieContext _context;

        public UnitOfWork(MovieContext context)
        {
            _context = context;
            Movies = new MovieRepository(_context);
        }

        public IMovieRepository Movies { get; private set; }


        public int Complete()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
