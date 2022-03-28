using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using YudemyAPI.Models;
using YudemyAPI.Models.DTO;
using YudemyAPI.Repositories;

namespace YudemyAPI.Services
{
    public class StudentService
    {
        private readonly ILogger<StudentService> _logger;
        private readonly StudentRepository studentRepository;
        private readonly CourseService courseService;

        public StudentService(ILogger<StudentService> logger, StudentRepository studentRepository, CourseService courseService)
        {
            _logger = logger;
            this.studentRepository = studentRepository;
            this.courseService = courseService;
        }

        public IEnumerable<Student> GetAll()
        {
            return studentRepository.GetAll();
        }

        public Student GetById(int id)
        {
            return studentRepository.GetById(id);
        }

        public Student Create(StudentRequest student)
        {
            Student newStudent = new Student(student.Name, student.Age);

            return studentRepository.Create(newStudent);
        }

        public bool BuyCourse(BuyCourseRequest buyCourseRequest)
        {
            var course = courseService.GetById(buyCourseRequest.CourseId);
            var student = studentRepository.GetById(buyCourseRequest.StudentId);

            // TODO verify if student already have this course

            if (student.Funds >= course.Price)
            {
                student.Courses.Add(course);
                student.DebitFunds(course.Price);

                studentRepository.Update(student);

                return true;
            }

            return false;
        }
    }
}
