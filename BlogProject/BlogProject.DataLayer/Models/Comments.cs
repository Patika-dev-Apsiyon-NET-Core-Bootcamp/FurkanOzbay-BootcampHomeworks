using System;
using System.Collections.Generic;

namespace BlogProject.DataLayer.Models
{
    public partial class Comments
    {
        public int Id { get; set; }
        public int? UserId { get; set; }
        public string Content { get; set; }

        public virtual Users User { get; set; }
    }
}
