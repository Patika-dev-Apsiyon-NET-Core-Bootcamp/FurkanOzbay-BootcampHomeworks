using System;
using System.Collections.Generic;

namespace BlogProject.DataLayer.Models
{
    public partial class Users
    {
        public Users()
        {
            Blogs = new HashSet<Blogs>();
            Comments = new HashSet<Comments>();
        }

        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }

        public virtual ICollection<Blogs> Blogs { get; set; }
        public virtual ICollection<Comments> Comments { get; set; }
    }
}
