using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitecture.Domain.Models
{
    public class User:Entity
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public ICollection<Comment> Comments { get; set; }
        public ICollection<Blog> Blogs { get; set; }
    }
}
