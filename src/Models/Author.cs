using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace YudemyAPI.Models
{
    public class Author
    {
        public int Id { get; private set; }
        public string Name { get; private set; }
        public ICollection<Course> Courses { get; private set; }

        public Author()
        {
            Courses = new HashSet<Course>();
        }

        public Author(string name) : this()
        {
            Name = name;
        }
    }
}
