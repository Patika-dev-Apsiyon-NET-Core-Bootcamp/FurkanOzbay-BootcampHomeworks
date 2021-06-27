using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace BlogProject.BusinessLayer.Repository.Abstract
{
    public interface IRepository<T> where T:class
    {
        IQueryable<T> GetAll();
        IQueryable<T> GetAll(Expression<Func<T,bool>> predicate);
        T GetById(int Id);
        T Get(Expression<Func<T, bool>> predicate);
        void Insert(T entity);
        void Update(T entity);
        void Delete(T entity);
        void Delete(int Id);
    }
}
