using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using YudemyAPI.Context;
using YudemyAPI.Models;

namespace YudemyAPI.Repositories
{
    public class StudentRepository
    {
        private readonly YudemyContext _context;

        public StudentRepository(YudemyContext yudemyContext)
        {
            this._context = yudemyContext;
        }

        public IEnumerable<Student> GetAll()
        {
            var result = _context.Students.ToList();
            return result;
        }

        public Student GetById(int id)
        {
            var result = _context.Students.Find(id);
            return result;
        }

        public Student GetWithCoursesById(int id)
        {
            var result = _context.Students.Where(s => s.Id == id).Include(c => c.Courses).First();
            return result;
        }

        public Student Create(Student student)
        {
            _context.Students.Add(student);
            _context.SaveChanges();

            return student;
        }

        public Student Update(Student newStudent)
        {
            Student student = GetById(newStudent.Id);

            _context.Entry(student).CurrentValues.SetValues(newStudent);
            _context.SaveChanges();

            return student;
        }
    }
}
