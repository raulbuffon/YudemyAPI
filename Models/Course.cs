using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace YudemyAPI.Models
{
    public class Course
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public int AuthorId { get; set }
        public Author Author { get; set; }
        public ICollection<Section> Sections { get; set; }
        public ICollection<Student> Students { get; set; }

        public Course()
        {
            Sections = new HashSet<Section>();
            Students = new HashSet<Student>();
        }
    }
}
