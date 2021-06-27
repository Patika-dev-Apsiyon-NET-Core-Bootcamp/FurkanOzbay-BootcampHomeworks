using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cookies.Models
{
    public class UserViewModel
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public List<string> Hobies { get; set; }
    }
}
