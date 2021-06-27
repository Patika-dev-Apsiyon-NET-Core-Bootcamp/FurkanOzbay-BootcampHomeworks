using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitecture.Application.ViewModel
{
    public class BlogViewModel
    {
        public string Title { get; set; }
        public List<CategoryViewModel> Categories { get; set; }
        public string Article { get; set; }
        public string UserName { get; set; }
        public int UserId { get; set; }
        public List<CommentViewModel> Comments { get; set; }
    }
}
