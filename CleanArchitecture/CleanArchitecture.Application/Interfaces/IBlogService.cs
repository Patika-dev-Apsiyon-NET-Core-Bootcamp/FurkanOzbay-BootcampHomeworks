using CleanArchitecture.Application.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Application.Interfaces
{
    public interface IBlogService
    {
        List<BlogViewModel> GetAllByCategory(int categoryId);
        Task<bool> Add(BlogViewModel blog);
    }
}
