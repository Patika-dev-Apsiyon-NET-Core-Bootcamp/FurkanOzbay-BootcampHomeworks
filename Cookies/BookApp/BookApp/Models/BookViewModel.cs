using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookApp.Models
{
    public class BookViewModel
    {
        public BookViewModel()
        {
            Categories = new List<string>();
        }

        public int Id { get; set; }
        public string BookName { get; set; }
        public string Author { get; set; }
        public DateTime Date { get; set; }
        public double Price { get; set; }
        public short PageNumbers { get; set; }
        public List<string> Categories { get; set; }
    }
}
