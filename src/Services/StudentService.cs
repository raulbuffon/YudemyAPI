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

        public StudentService(ILogger<StudentService> logger, StudentRepository studentRepository)
        {
            _logger = logger;
            this.studentRepository = studentRepository;
        }

        public IEnumerable<Student> GetAll()
        {
            return studentRepository.GetAll();
        }

        public Student GetById(int id)
        {
            return studentRepository.GetById(id);
        }

        public Student Create(StudentDTO student)
        {
            Student newStudent = new Student(student.Name, student.Age);

            return studentRepository.Create(newStudent);
        }
    }
}
