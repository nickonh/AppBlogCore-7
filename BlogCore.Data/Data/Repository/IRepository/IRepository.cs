﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BlogCore.Data.Data.Repository.IRepository
{
    public interface IRepository<T> where T: class
    {
        T Get(int id);

        IEnumerable<T> GetAll(
            Expression
            <Func<T, bool>> filter = null,
            Func<IQueryable<T>, IOrderedQueryable<T>> orderby = null,
            string includeProperties = null
            );

        T GetFirstOrDefault(
            Expression<Func<T, bool>> filter = null,
            string includePropierties = null
            );

        void Add(T entity);
        void Remove(int id);
        void Remove(T entity);
    }
}
