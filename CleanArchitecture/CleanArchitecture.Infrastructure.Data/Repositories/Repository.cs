using CleanArchitecture.Domain.Interfaces;
using CleanArchitecture.Domain.Models;
using CleanArchitecture.Infrastructure.Data.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Infrastructure.Data.Repositories
{
    public class Repository<T> : IRepository<T> where T : Entity
    {
        protected readonly BlogDbContext _context = null;
        private DbSet<T> _entities;

        public Repository(BlogDbContext context)
        {
            _context = context;
            _entities = context.Set<T>();
        }

        public async Task<int> Add(T entity)
        {
            _entities.Add(entity);
           return await _context.SaveChangesAsync();
        }

        public int Delete(int Id)
        {
            T entity = _entities.FirstOrDefault(x => x.Id == Id);
            if (entity == default) return -1;
            _entities.Remove(entity);
            return _context.SaveChanges();
        }

        public List<T> GetAll()
        {
            return _entities.ToList();
        }

        public T GetById(int Id)
        {
            return _entities.FirstOrDefault(x => x.Id == Id);
            
        }

        public int Update(T entity)
        {
            return _context.SaveChanges();
        }
    }
}
