using BlogCore.Data.Data.Repository.IRepository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BlogCore.Data.Data.Repository
{
    public class Repository<T> : IRepository<T> where T : class
    {
        protected readonly DbContext _Context;
        internal DbSet<T> dbSet;

        public Repository(DbContext _context)
        {
            _Context= _context;
            this.dbSet= _context.Set<T>();
        }

        public void Add(T entity)
        {
            throw new NotImplementedException();
        }

        public T Get(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> GetAll(Expression<Func<T, bool>> filter = null, Func<IQueryable<T>, IOrderedQueryable<T>> orderby = null, string includeProperties = null)
        {
            throw new NotImplementedException();
        }

        public T GetFirstOrDefault(Expression<Func<T, bool>> filter = null, string includePropierties = null)
        {
            throw new NotImplementedException();
        }

        public void Remove(int id)
        {
            throw new NotImplementedException();
        }

        public void Remove(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
