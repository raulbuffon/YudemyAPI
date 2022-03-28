using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace YudemyAPI.Models.DTO
{
    public class CourseRequest
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public int AuthorId { get; set; }
    }
}
