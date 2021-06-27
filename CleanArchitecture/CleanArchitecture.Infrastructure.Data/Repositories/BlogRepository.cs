using CleanArchitecture.Domain.Interfaces;
using CleanArchitecture.Domain.Models;
using CleanArchitecture.Infrastructure.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Infrastructure.Data.Repositories
{
    public class BlogRepository : Repository<Blog>, IBlogRepository
    {

        BlogRepository(BlogDbContext context) : base(context)
        {
        }

        public List<Blog> GetAllByCategory(int categoryId)
        {
            //category var mı?? 
            //aktif mi değil mi??
            return _context.Blogs.Where(x => x.Categories.Any(c => c.Id == categoryId && c.Status)).ToList();
        }

    }
}
