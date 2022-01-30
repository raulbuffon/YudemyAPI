using Microsoft.Extensions.Logging;
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
        private readonly ILogger<CourseService> _logger;
        private readonly CourseRepository courseRepository;

        public CourseService(ILogger<CourseService> logger, CourseRepository courseRepository)
        {
            _logger = logger;
            this.courseRepository = courseRepository;
        }

        public IEnumerable<Course> GetAll()
        {
            return courseRepository.GetAll();
        }

        public Course GetById(int id)
        {
            return courseRepository.GetById(id);
        }

        public Course Create(CourseDTO course)
        {
            Course newCourse = new Course(course.Title, course.Description, course.Price, course.AuthorId);

            return courseRepository.Create(newCourse);
        }
    }
}
