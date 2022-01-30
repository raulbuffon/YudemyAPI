using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace YudemyAPI.Models
{
    public class Course
    {
        public int Id { get; private set; }
        public string Title { get; private set; }
        public string Description { get; private set; }
        public double Price { get; private set; }
        public int AuthorId { get; private set; }
        public Author Author { get; private set; }
        public ICollection<Section> Sections { get; private set; }
        public ICollection<Student> Students { get; private set; }

        public Course()
        {
            Sections = new HashSet<Section>();
            Students = new HashSet<Student>();
        }

        public Course(string title, string description, double price, int authorId) : this()
        {
            Title = title;
            Description = description;
            Price = price;
            AuthorId = authorId;
        }
    }
}
