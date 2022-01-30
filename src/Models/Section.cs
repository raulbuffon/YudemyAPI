using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace YudemyAPI.Models
{
    public class Section
    {
        public int Id { get; private set; }
        public string Title { get; private set; }
        public int CourseId { get; private set; }
        public Course Course { get; private set; }

        public Section(string title, int courseId)
        {
            Title = title;
            CourseId = courseId;
        }
    }
}
