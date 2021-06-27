using System;
using System.Collections.Generic;

namespace BlogProject.DataLayer.Models
{
    public partial class Categories
    {
        public Categories()
        {
            Blogs = new HashSet<Blogs>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Blogs> Blogs { get; set; }
    }
}
