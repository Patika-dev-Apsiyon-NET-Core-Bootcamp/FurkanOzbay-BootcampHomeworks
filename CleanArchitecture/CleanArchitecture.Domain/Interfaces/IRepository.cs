using CleanArchitecture.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Domain.Interfaces
{
    public interface IRepository<T> where T:IEntity
    {
        Task<int> Add(T entity);
        int Update(T entity);
        int Delete(int Id);
        T GetById(int Id);
        List<T> GetAll();
    }
}
