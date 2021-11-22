using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using YudemyAPI.Context;
using YudemyAPI.Models;

namespace YudemyAPI.Services
{
    public class CourseService
    {
        private readonly YudemyContext _context;

        public CourseService(YudemyContext yudemyContext)
        {
            this._context = yudemyContext;
        }

        public IEnumerable<Course> GetAll()
        {
            var result = _context.Courses.ToList();
            return result;
        }

        public Course GetById(int id)
        {
            var result = _context.Courses.Where(x => x.Id == id).First();
            return result;
        }
    }
}
