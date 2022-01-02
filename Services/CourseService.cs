using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using YudemyAPI.Context;
using YudemyAPI.Models;
using YudemyAPI.Models.DTO;
using YudemyAPI.Repositories;

namespace YudemyAPI.Services
{
    public class CourseService
    {
        private readonly CourseRepository courseRepository;

        public CourseService(CourseRepository courseRepository)
        {
            this.courseRepository = courseRepository;
        }

        public IEnumerable<Course> GetAllCourses()
        {
            return courseRepository.GetAllCourses();
        }

        public Course GetById(int id)
        {
            return courseRepository.GetById(id);
        }

        public Course CreateCourse(CourseDTO course)
        {
            Course newCourse = new Course
            {
                Title = course.Title,
                Description = course.Description,
                Price = course.Price,
                AuthorId = course.AuthorId
            };

            return courseRepository.CreateCourse(newCourse);
        }
    }
}
