using BlogProject.BusinessLayer.Repository.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlogProject.BusinessLayer.Repository.Concrete
{
    public class EFUnitOfWork : IUnitOfWork
    {
        private readonly DbContext _dbContext;
        private bool disposed = false;

        public EFUnitOfWork(DbContext dbContext)
        {
            _dbContext = dbContext;
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposing)
            {
                if (disposing)
                    _dbContext.Dispose();
            }
            disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        public IRepository<T> GetRepository<T>() where T : class
        {
            return new EFRepository<T>(_dbContext);
        }

        public int SaveChanges()
        {
            try
            {
                return _dbContext.SaveChanges();
            }
            catch (Exception ex)
            {

                throw new Exception(ex.InnerException.Message);
            }
        }
    }
}
