using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace YudemyAPI.Models
{
    public class Author
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Course> Courses { get; set; }

        public Author()
        {
            Courses = new HashSet<Course>();
        }
    }
}
