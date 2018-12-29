using BollywoodMovie.Core.Domain;
using System.Data.Entity;

namespace BollywoodMovie.Persistence
{
    public class MovieContext : DbContext
    {
        public MovieContext()
            : base("name=MovieContext")
        {
            this.Configuration.LazyLoadingEnabled = false;
        }

        public virtual DbSet<Movie> Movies { get; set; }
     

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //modelBuilder.Configurations.Add(new MovieConfiguration());
        }
    }
}