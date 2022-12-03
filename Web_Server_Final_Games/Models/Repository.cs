using Microsoft.EntityFrameworkCore;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Web_Server_Final_Games.Models
{
    public class Repository<T> : IRepository<T> where T : class
    {
        protected GamesContext context { get; set; }

        private DbSet<T> dbset { get; set; }
        
        public Repository(GamesContext ctx)
        {
            this.context = ctx;
            dbset = context.Set<T>();
        }

        public virtual IEnumerable<T> List(QueryOptions<T> options)
        {
            IQueryable<T> query = dbset;
            foreach (string include in options.GetIncludes())
            {
                query = query.Include(include);
            }

            return query.ToList();
        }

        public T Get(int id) => dbset.Find(id);
        

        

        public virtual void Insert(T entity) => dbset.Add(entity);
        public virtual void Update(T entity) => dbset.Update(entity);
        public virtual void Delete(T entity) => dbset.Remove(entity);
        public virtual void Save() => context.SaveChanges();

        public T Get(QueryOptions<T> options)
        {
            throw new System.NotImplementedException();
        }
    }
}
