using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CleanArchitecture.Domain.Models
{
    public class Blog : Entity
    {
        public string Title { get; set; }
        //public int CategoryId { get; set; }
        //[ForeignKey("CategoryId")]
        public virtual List<Category> Categories { get; set; }
        public string Article { get; set; }
        [ForeignKey("UserId")]
        public virtual User User { get; set; }
        public int UserId { get; set; }
        public ICollection<Comment> Comments { get; set; }
    }
}
