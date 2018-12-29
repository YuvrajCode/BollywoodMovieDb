using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BollywoodMovie.Core.Repository
{
    public interface IRepository<Entity> where Entity : class
    {
        Entity Get(int id);
        IEnumerable<Entity> GetAll();
        IEnumerable<Entity> Find(Expression<Func<Entity,bool>> predicate);

        void Add(Entity entity);
        void Remove(Entity entity);
    }
}
