using BlogProject.BusinessLayer.Repository.Abstract;
using BlogProject.BusinessLayer.Repository.Concrete;
using BlogProject.DataLayer.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BlogProject.BusinessLayer.Business
{
    public class CategoryBusiness
    {
        private IRepository<Categories> _categoryRepository;
        private IUnitOfWork _categoryUnitOfWork;
        private DbContext _dbContext;

        public CategoryBusiness()
        {
            _dbContext = new BlogProjectDbContext();
            _categoryUnitOfWork = new EFUnitOfWork(_dbContext);
            _categoryRepository = _categoryUnitOfWork.GetRepository<Categories>();
        }


        public List<Categories> GetCategories()
        {
            return _categoryRepository.GetAll().ToList();
        }
    }
}
