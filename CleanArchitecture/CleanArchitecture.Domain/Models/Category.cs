using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitecture.Domain.Models
{
    public class Category : Entity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public bool Status { get; set; }
        public ICollection<Blog> Blogs { get; set; }
    }
}
