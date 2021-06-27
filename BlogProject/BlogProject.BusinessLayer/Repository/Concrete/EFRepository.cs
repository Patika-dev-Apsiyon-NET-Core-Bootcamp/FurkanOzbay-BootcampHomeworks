using BlogProject.BusinessLayer.Repository.Abstract;
using BlogProject.DataLayer.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BlogProject.BusinessLayer.Repository.Concrete
{
    public class EFRepository<T> : IRepository<T> where T:class
    {
        private readonly DbContext _dbContext;
        private readonly DbSet<T> _dbSet;

        public EFRepository(DbContext dbContext)
        {
            _dbContext = dbContext;
            _dbSet = _dbContext.Set<T>();
        }

        public void Delete(T entity)
        {
            _dbSet.Remove(entity);
        }

        public void Delete(int Id)
        {
            _dbSet.Remove(GetById(Id));
        }

        public T Get(System.Linq.Expressions.Expression<Func<T, bool>> predicate)
        {
            return _dbSet.Where(predicate).SingleOrDefault();
        }

        public IQueryable<T> GetAll()
        {
            return _dbSet;
        }

        public IQueryable<T> GetAll(System.Linq.Expressions.Expression<Func<T, bool>> predicate)
        {
            return _dbSet.Where(predicate);
        }

        public T GetById(int Id)
        {
            return _dbSet.Find(Id);
        }

        public void Insert(T entity)
        {
            _dbSet.Add(entity);
        }

        public void Update(T entity)
        {
            _dbSet.Attach(entity);
            _dbContext.Entry(entity).State = EntityState.Modified;
        }
    }
}
