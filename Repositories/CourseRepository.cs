using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using YudemyAPI.Context;
using YudemyAPI.Models;
using YudemyAPI.Models.DTO;

namespace YudemyAPI.Repositories
{
    public class CourseRepository
    {
        private readonly YudemyContext _context;

        public CourseRepository(YudemyContext yudemyContext)
        {
            this._context = yudemyContext;
        }

        public IEnumerable<Course> GetAllCourses()
        {
            var result = _context.Courses.ToList();
            return result;
        }

        public Course GetById(int id)
        {
            var result = _context.Courses.Where(x => x.Id == id).First();
            return result;
        }

        public Course CreateCourse(Course course)
        {
            _context.Courses.Add(course);
            _context.SaveChanges();

            return course;
        }
    }
}
