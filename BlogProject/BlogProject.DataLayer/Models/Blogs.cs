using System;
using System.Collections.Generic;

namespace BlogProject.DataLayer.Models
{
    public partial class Blogs
    {
        public int Id { get; set; }
        public int? CategoryId { get; set; }
        public int? UserId { get; set; }
        public string Name { get; set; }

        public virtual Categories Category { get; set; }
        public virtual Users User { get; set; }
    }
}
