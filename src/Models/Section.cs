using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace YudemyAPI.Models
{
    public class Section
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int CourseId { get; set; }
        public Course Course { get; set; }
    }
}
